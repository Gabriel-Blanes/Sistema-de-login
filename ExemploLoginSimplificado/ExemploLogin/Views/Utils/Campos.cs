using System.Windows.Forms;

namespace ExemploLogin.Views.Utils
{
    public static class Campos
    {
        public static void LimparCampos(this Control fatherControl)
        {
            foreach (var control in fatherControl.Controls)
            {
                if (control is Panel panel)
                {
                    LimparCampos(panel);
                }
                else if (control is GroupBox groupBox)
                {
                    LimparCampos(groupBox);
                }
                else if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.DropDownStyle == ComboBoxStyle.DropDownList)
                        comboBox.SelectedIndex = -1;
                    else
                        comboBox.Text = string.Empty;
                }
            }
        }
    }
}
