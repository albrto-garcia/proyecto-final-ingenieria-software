using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Reflection;
using System.Net.Mail;
using System.Net;
using System.Globalization;

namespace Utilidades
{
    public class Utilidades
    {
        public static SQLServer sql = new SQLServer();
        public static string ruta = @"C:\Users\Usuario\Documents\MEGAsync\ALBERT\INGENIERÍA SOFTWARE\INGENIERÍA DE SOFTWARE - SAPC\V.- PRESENTACION TÉCNICA\1.- PROGRAMA FUENTE\";

        public static string EncriptacionSHA1(string cadena)
        {

            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }

        public static bool CorreoValido(string email)
        {
            string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            Regex valido = new Regex(emailRegex);

            if (valido.IsMatch(email))
                return true;
            else
                return false;
        }

        public static bool SoloNumeros(string cadena)
        {
            string numerosRegex = @"^[0-9]*$";

            Regex valido = new Regex(numerosRegex);

            if (valido.IsMatch(cadena))
                return true;
            else
                return false;
        }

        public static void SoloNumeros(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números.
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso.
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan.
                e.Handled = true;
            }
        }

        public static bool SoloLetras(string cadena)
        {
            string numerosRegex = @"^[a-zA-Z]+$";

            Regex valido = new Regex(numerosRegex);

            if (valido.IsMatch(cadena))
                return true;
            else
                return false;
        }

        public static void SoloLetras(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan letras.
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso.
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan.
                e.Handled = true;
            }
        }

        public static bool SoloAlfanumerico(string cadena)
        {
            string numerosRegex = @"^[a-zA-Z0-9]+$";

            Regex valido = new Regex(numerosRegex);

            if (valido.IsMatch(cadena))
                return true;
            else
                return false;
        }

        public static void SoloAlfanumerico(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números y letras.
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso.
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan.
                e.Handled = true;
            }
        }

        public static void ValidarInput(Control textbox, KeyPressEventArgs e)
        {
            if (textbox is Herramientas.TextBox)
            {
                Herramientas.TextBox obj = (Herramientas.TextBox)textbox;

                if (obj.SoloNumeros)
                {
                    SoloNumeros(e);
                }

                if (obj.SoloLetras)
                {
                    SoloLetras(e);
                }

                if (obj.SoloAlfanumerico)
                {
                    SoloAlfanumerico(e);
                }
            }

            if (textbox is Herramientas.MaskedTextBox)
            {
                Herramientas.MaskedTextBox obj = (Herramientas.MaskedTextBox)textbox;

                if (obj.SoloNumeros)
                {
                    SoloNumeros(e);
                }

                if (obj.SoloLetras)
                {
                    SoloLetras(e);
                }

                if (obj.SoloAlfanumerico)
                {
                    SoloAlfanumerico(e);
                }
            }
        }

        public static int NumeroFactura(string proceso, string tabla)
        {
            try
            {
                string comando = String.Format("SELECT TOP 1 {0} FROM {1} ORDER BY {2} DESC", proceso, tabla, proceso);

                var DS = sql.EjecutarBD(comando);

                int num = int.Parse(DS.Tables[0].Rows[0][proceso].ToString());

                return num <= 0 ? 1 : num + 1;//int.Parse(num) + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }

        public static void FormatoPrecio(TextBox ctrl, EventHandler ctrl_TextChanged, string cadena)
        {
            string value = ctrl.Text.Replace(",", "").Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;

            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;

                ctrl.TextChanged -= ctrl_TextChanged;

                ctrl.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", ul);
                ctrl.TextChanged += ctrl_TextChanged;
                ctrl.Select(ctrl.Text.Length, 0);
            }

            bool goodToGo = SoloPrecio(ctrl.Text);

            if (!goodToGo)
            {
                ctrl.Text = "$0.00";
                ctrl.Select(ctrl.Text.Length, 0);
            }
        }

        public static bool SoloPrecio(string cadena)
        {
            Regex precio = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return precio.IsMatch(cadena);
        }

        public static Form MDIParentMenu()
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form form in fc)
            {
                if (form.Name == "Menu")
                {
                    return form;
                }
            }

            return null;
        }

        public static void EnviarEmail(List<string> emails, string asunto, string cuerpo, string ruta)
        {
            try
            {
                MailMessage email = new MailMessage();

                if (emails.Count > 1)
                    foreach (string correo in emails)
                    {
                        MailAddress to = new MailAddress(correo);
                        email.Bcc.Add(to);
                    }
                else
                {
                    MailAddress to = new MailAddress(emails[0]);
                    email.Bcc.Add(to);
                }

                email.Subject = asunto;
                email.SubjectEncoding = System.Text.Encoding.UTF8;

                //if (txtCC.ReadOnly == false)
                //{
                //    email.CC.Add(txtCC.Text);
                //}

                //if (txtCCO.ReadOnly == false)
                //{
                //    email.Bcc.Add(txtCCO.Text);
                //}

                email.Body = cuerpo;
                email.BodyEncoding = System.Text.Encoding.UTF8;
                email.IsBodyHtml = true;
                email.From = new MailAddress("marlonesuncrack@gmail.com");

                Attachment archivo = new Attachment(ruta);
                email.Attachments.Add(archivo);

                SmtpClient cliente = new SmtpClient();
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential("marlonesuncrack@gmail.com", "marlonesuncrack4309");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";

                cliente.Send(email);
                email.Dispose();
                MessageBox.Show("Correo fue enviado correctamente!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al enviar correo: " + e.Message);
            }
        }

        public static void ConfiguracionBotones(Form formulario)
        {
            int cont = 0;
            ImageList img = new ImageList();
            img.ImageSize = new Size(44, 44);
            img.Images.Add(Imagenes.ImagesResources.guardar);
            img.Images.Add(Imagenes.ImagesResources.guardar_e_imprimir);
            img.Images.Add(Imagenes.ImagesResources.seleccionar);
            img.Images.Add(Imagenes.ImagesResources.modificar);
            img.Images.Add(Imagenes.ImagesResources.eliminar);
            img.Images.Add(Imagenes.ImagesResources.cancelar);
            img.Images.Add(Imagenes.ImagesResources.salir);
            img.Images.Add(Imagenes.ImagesResources.buscar);
            img.Images.Add(Imagenes.ImagesResources.agregar);
            img.Images.Add(Imagenes.ImagesResources.imagen_por_defecto_boton);
            img.Images.Add(Imagenes.ImagesResources.capturar);
            img.Images.Add(Imagenes.ImagesResources.login);
            img.Images.Add(Imagenes.ImagesResources.imprimir);
            img.Images.Add(Imagenes.ImagesResources.amortizar);

            foreach (Control ctrl in formulario.Controls)
            {
                if (ctrl is Panel)
                {
                    cont = ctrl.Controls.OfType<Button>().Count();

                    foreach (Panel pnl in formulario.Controls.OfType<Panel>())
                    {
                        foreach (Control pnl_ctrl in pnl.Controls)
                        {
                            if (pnl_ctrl is Button)
                            {
                                if (pnl_ctrl.Name.Contains("Imprimir"))
                                    ((Button)pnl_ctrl).ImageIndex = 1;
                                else
                                   if (pnl_ctrl.Name.Contains("Guardar"))
                                    ((Button)pnl_ctrl).ImageIndex = 0;
                                else
                                           if (pnl_ctrl.Name.Contains("Seleccionar"))
                                    ((Button)pnl_ctrl).ImageIndex = 2;
                                else
                                               if (pnl_ctrl.Name.Contains("Modificar"))
                                    ((Button)pnl_ctrl).ImageIndex = 3;
                                else
                                                   if (pnl_ctrl.Name.Contains("Eliminar"))
                                    ((Button)pnl_ctrl).ImageIndex = 4;
                                else
                                                       if (pnl_ctrl.Name.Contains("Cancelar"))
                                    ((Button)pnl_ctrl).ImageIndex = 5;
                                else
                                                           if (pnl_ctrl.Name.Contains("Salir"))
                                    ((Button)pnl_ctrl).ImageIndex = 6;
                                else
                                                               if (pnl_ctrl.Name.Contains("Buscar"))
                                    ((Button)pnl_ctrl).ImageIndex = 7;
                                else
                                                               if (pnl_ctrl.Name.Contains("Agregar"))
                                    ((Button)pnl_ctrl).ImageIndex = 8;
                                else
                                                                   if (pnl_ctrl.Name.Contains("Imagen"))
                                    ((Button)pnl_ctrl).ImageIndex = 9;
                                else
                                                                       if (pnl_ctrl.Name.Contains("Capturar") || ctrl.Name.Contains("Iniciar"))
                                    ((Button)pnl_ctrl).ImageIndex = 10;
                                else
                                if (pnl_ctrl.Name.Contains("Ingresar"))
                                    ((Button)pnl_ctrl).ImageIndex = 11;
                                else
                                if (pnl_ctrl.Name.Contains("Imprimir"))
                                    ((Button)pnl_ctrl).ImageIndex = 12;
                                else
                                    if (pnl_ctrl.Name.Contains("Amortizar"))
                                    ((Button)pnl_ctrl).ImageIndex = 13;

                                ((Button)pnl_ctrl).ImageAlign = ContentAlignment.MiddleRight;
                                ((Button)pnl_ctrl).TextImageRelation = TextImageRelation.ImageBeforeText;
                                ((Button)pnl_ctrl).TextAlign = ContentAlignment.MiddleCenter;
                                ((Button)pnl_ctrl).ImageList = img;
                            }
                        }
                    }

                    cont = ctrl.Controls.OfType<Button>().Count();
                }
                else if (ctrl is Button)
                {
                    if (ctrl.Name.Contains("Imprimir"))
                        ((Button)ctrl).ImageIndex = 1;
                    else
                                if (ctrl.Name.Contains("Guardar"))
                        ((Button)ctrl).ImageIndex = 0;
                    else
                                        if (ctrl.Name.Contains("Seleccionar"))
                        ((Button)ctrl).ImageIndex = 2;
                    else
                                            if (ctrl.Name.Contains("Modificar"))
                        ((Button)ctrl).ImageIndex = 3;
                    else
                                                if (ctrl.Name.Contains("Eliminar"))
                        ((Button)ctrl).ImageIndex = 4;
                    else
                                                    if (ctrl.Name.Contains("Cancelar"))
                        ((Button)ctrl).ImageIndex = 5;
                    else
                                                        if (ctrl.Name.Contains("Salir"))
                        ((Button)ctrl).ImageIndex = 6;
                    else
                        if (ctrl.Name.Contains("Buscar"))
                        ((Button)ctrl).ImageIndex = 7;
                    else
                            if (ctrl.Name.Contains("Agregar"))
                        ((Button)ctrl).ImageIndex = 8;
                    else
                                if (ctrl.Name.Contains("Imagen"))
                        ((Button)ctrl).ImageIndex = 9;
                    else
                                    if (ctrl.Name.Contains("Capturar") || ctrl.Name.Contains("Iniciar"))
                        ((Button)ctrl).ImageIndex = 10;
                    else
                                if (ctrl.Name.Contains("Ingresar"))
                        ((Button)ctrl).ImageIndex = 11;
                    else
                                if (ctrl.Name.Contains("Imprimir"))
                        ((Button)ctrl).ImageIndex = 12;
                    else
                                    if (ctrl.Name.Contains("Amortizar"))
                        ((Button)ctrl).ImageIndex = 13;

                    ((Button)ctrl).ImageAlign = ContentAlignment.MiddleRight;
                    ((Button)ctrl).TextImageRelation = TextImageRelation.ImageBeforeText;
                    ((Button)ctrl).TextAlign = ContentAlignment.MiddleCenter;
                    ((Button)ctrl).ImageList = img;
                }
            }
        }

        public static void AjustarCbx(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is ComboBox)
                {
                    if ((ctrl as ComboBox).Items.Count > 0)
                    {
                        object[] items = new object[(ctrl as ComboBox).Items.Count];
                        (ctrl as ComboBox).Items.CopyTo(items, 0);
                        ctrl.Width = items.Select(obj => TextRenderer.MeasureText((ctrl as ComboBox).GetItemText(obj), ctrl.Font).Width).Max() + SystemInformation.VerticalScrollBarWidth;
                    }
                }
            }
        }

        public static Form Form(string formulario)
        {
            foreach (Form f in Application.OpenForms)
            {
                if ((f.CompanyName + "." + f.Name) == formulario)
                    return f;
            }

            return null;
        }

        public static bool FormAbierto(string formulario)
        {
            foreach (Form f in Application.OpenForms)
            {
                if ((f.CompanyName + "." + f.Name) == formulario)
                    return true;
            }

            return false;
        }

        public static Herramientas.Form ObtenerFormPorNombre(string formulario)
        {
            var formType = Assembly.GetEntryAssembly().GetTypes()
                  .Where(a => a.BaseType == typeof(Herramientas.Form) && a.FullName == formulario)
                  .FirstOrDefault();

            if (formType == null)
                return null;

            return Activator.CreateInstance(formType) as Herramientas.Form;
        }

        public static void SoloUnForm(Form mdi_parent, string formulario)
        {
            formulario = "Proyecto_SAPC." + formulario;

            if (mdi_parent.MdiChildren.Length == 0)
            {
                var obj = ObtenerFormPorNombre(formulario);
                obj.MdiParent = mdi_parent;
                obj.Show();
            }
            else
            {
                MessageBox.Show("Debe cerrar los formularios abiertos para utilizar esta opción!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void Limpiar(Control controles)
        {
            foreach (Control control in controles.Controls)
            {
                if (control.Name.Contains("txtSubtotal") || control.Name.Contains("txtTotal") ||
                    control.Name.Contains("txtItbis") || control.Name.Contains("txtDescuento") ||
                    control.Name.Contains("txtMontoItbis") || control.Name.Contains("txtMontoDescuento"))
                {
                    ((TextBox)control).Text = "0.00";
                    return;
                }

                if (control is Panel)
                {
                    foreach (Control pnl_control in control.Controls)
                    {
                        if (pnl_control is TextBox || pnl_control is MaskedTextBox)
                        {
                            ((TextBox)pnl_control).Clear();
                        }

                        if (pnl_control is RichTextBox)
                        {
                            ((RichTextBox)pnl_control).Clear();
                        }

                        if (pnl_control is ComboBox || pnl_control is RadioButton || pnl_control is CheckBox)
                        {
                            if (((ComboBox)pnl_control).Items.Count > 0)
                                ((ComboBox)pnl_control).SelectedIndex = 0;
                        }

                        if (pnl_control is PictureBox)
                        {
                            if (pnl_control.Name == "picImagen")
                                ((PictureBox)pnl_control).Image = Imagenes.ImagesResources.imagen_por_defecto;

                            if (pnl_control.Name == "picCodigoBarras")
                                if (((PictureBox)pnl_control).Image != null)
                                    ((PictureBox)pnl_control).Image = null;
                        }

                        if (pnl_control is DateTimePicker)
                        {
                            ((DateTimePicker)pnl_control).Value = DateTime.Parse(sql.FechaBD());
                        }
                    }
                }
                else
                    if (control is GroupBox)
                {
                    foreach (Control gp_control in control.Controls)
                    {
                        if (gp_control is TextBox || gp_control is MaskedTextBox)
                        {
                            ((TextBox)gp_control).Clear();
                        }

                        if (gp_control is RichTextBox)
                        {
                            ((RichTextBox)gp_control).Clear();
                        }

                        if (gp_control is ComboBox || gp_control is RadioButton || gp_control is CheckBox)
                        {
                            if (((ComboBox)gp_control).Items.Count > 0)
                                ((ComboBox)gp_control).SelectedIndex = 0;
                        }

                        if (gp_control is PictureBox)
                        {
                            if (gp_control.Name == "picImagen")
                                ((PictureBox)gp_control).Image = Imagenes.ImagesResources.imagen_por_defecto;

                            if (gp_control.Name == "picCodigoBarras")
                                if (((PictureBox)gp_control).Image != null)
                                    ((PictureBox)gp_control).Image = null;
                        }

                        if (gp_control is DateTimePicker)
                        {
                            ((DateTimePicker)gp_control).Value = DateTime.Parse(sql.FechaBD());
                        }
                    }
                }
                else
                {
                    if (control is TextBox || control is MaskedTextBox)
                    {
                        ((TextBox)control).Clear();
                    }

                    if (control is RichTextBox)
                    {
                        ((RichTextBox)control).Clear();
                    }

                    if (control is ComboBox || control is RadioButton || control is CheckBox)
                    {
                        if (((ComboBox)control).Items.Count > 0)
                            ((ComboBox)control).SelectedIndex = 0;
                    }

                    if (control is PictureBox)
                    {
                        if (control.Name == "picImagen")
                            ((PictureBox)control).Image = Imagenes.ImagesResources.imagen_por_defecto;

                        if (control.Name == "picCodigoBarras")
                            if (((PictureBox)control).Image != null)
                                ((PictureBox)control).Image = null;
                    }

                    if (control is DateTimePicker)
                    {
                        ((DateTimePicker)control).Value = DateTime.Parse(sql.FechaBD());
                    }
                }
            }
        }

        public static SqlConnection conexionSQLServer = new SqlConnection("Data Source=DESKTOP-SVAHGNA;Initial Catalog=IngenieriaSoftware;Integrated Security=True");
        public virtual SqlConnection ConectarBD() { return null; }
        public virtual SqlConnection DesconectarBD() { return null; }
        public virtual DataSet EjecutarBD(string comando) { return null; }
        public virtual string FechaBD() { return null; }
    }

    public partial class SQLServer : Utilidades
    {
        public override SqlConnection ConectarBD()
        {
            try
            {
                if (conexionSQLServer.State != ConnectionState.Open)
                {
                    conexionSQLServer.Open();
                    return conexionSQLServer;
                }
                else
                    return null;
            }
            catch (StackOverflowException) { return conexionSQLServer; }
            catch (Exception)
            {
                return conexionSQLServer;
            }
        }

        public override SqlConnection DesconectarBD()
        {
            try
            {
                if (conexionSQLServer.State == ConnectionState.Open)
                {
                    conexionSQLServer.Close();
                    return conexionSQLServer;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override DataSet EjecutarBD(string comando)
        {
            try
            {
                ConectarBD();
                DataSet DS = new DataSet();
                SqlDataAdapter Adaptador = new SqlDataAdapter(comando, conexionSQLServer);
                Adaptador.Fill(DS);
                DesconectarBD();
                return DS;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override string FechaBD()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT GETDATE() as CurrentTime";
            comando.CommandType = CommandType.Text;
            comando.Connection = conexionSQLServer;
            ConectarBD();
            var fecha = (DateTime)comando.ExecuteScalar();
            DesconectarBD();

            return fecha.ToString();
        }
    }
}
