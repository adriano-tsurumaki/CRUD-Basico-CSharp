using System.Drawing;
using System.Windows.Forms;

namespace CRUD___Adriano.Features.Utils
{
    public static class GridViewExtension
    {
        public static DataGridViewTextBoxColumn TextBoxColumnPadrao(DataGridViewCell cellTemplate, string nome, string nomeDaPropriedade, bool apenasLeitura) =>
            new DataGridViewTextBoxColumn()
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
            };
    }
}
