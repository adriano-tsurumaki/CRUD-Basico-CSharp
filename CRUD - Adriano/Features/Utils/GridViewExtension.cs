using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Utils
{
    public static class GridViewExtension
    {
        public static void ConfiguracaoPadrao(this DataGridView gridView)
        {
            gridView.RowHeadersVisible = false;
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToOrderColumns = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public static void ConfiguracaoHeaderPadrao(this DataGridView gridView)
        {
            var cellHeaderStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(23, 31, 32),
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point),
                ForeColor = Color.White,
                Padding = new Padding(2),
                SelectionBackColor = Color.FromArgb(23, 31, 32),
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode = DataGridViewTriState.True
            };

            gridView.ColumnHeadersDefaultCellStyle = cellHeaderStyle;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        public static void TextBoxColumnPadrao(this DataGridView gridView, DataGridViewCell cellTemplate, string nome, string nomeDaPropriedade, bool apenasLeitura)
        {
            gridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                CellTemplate = cellTemplate,
                Name = nome,
                DataPropertyName = nomeDaPropriedade,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.DodgerBlue,
                    BackColor = Color.FromArgb(23, 31, 32),
                    SelectionBackColor = Color.LightSeaGreen,
                    Padding = new Padding(2)
                },
                ReadOnly = apenasLeitura,
            });
        }
        
        public static void ButtonColumnPadrao(this DataGridView gridView, string nome)
        {
            gridView.Columns.Add(new DataGridViewButtonColumn()
            {
                CellTemplate = new DataGridViewButtonCell(),
                HeaderText = nome,
                Name = nome
            });
        }

        public static object BindProperty(this DataGridView gridView, object propriedade, string nomeDaPropriedade)
        {
            string valorDeRetorno = "";

            if (nomeDaPropriedade.Contains("."))
            {
                var leftPropertyName = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));
                var arrayDePropriedades = propriedade.GetType().GetProperties();
                foreach (var informacaoDaPropriedade in arrayDePropriedades)
                {
                    if (informacaoDaPropriedade.Name == leftPropertyName)
                    {
                        valorDeRetorno = (string)gridView.BindProperty(
                          informacaoDaPropriedade.GetValue(propriedade, null),
                          nomeDaPropriedade[(nomeDaPropriedade.IndexOf(".") + 1)..]);
                        break;
                    }
                }
            }
            else
            {
                Type tipoDePropriedade;
                PropertyInfo informacaoDaPropriedade;
                tipoDePropriedade = propriedade.GetType();
                informacaoDaPropriedade = tipoDePropriedade.GetProperty(nomeDaPropriedade);
                valorDeRetorno = informacaoDaPropriedade.GetValue(propriedade, null).ToString();
            }
            return valorDeRetorno;
        }
    }
}
