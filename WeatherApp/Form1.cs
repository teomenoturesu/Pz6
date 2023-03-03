using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            WeatherDataGrid.DataSource = _weather.Weathers.ToList();
        }

        private void button1_Click(object sender, System.EventArgs e)//Сброс
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            WeatherDataGrid.DataSource = _weather.Weathers.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e)//Вывод +
        {
            WeatherDataGrid.DataSource = _weather.Weathers.Where(i => i.Temperature > 0).ToList();
        }

        private void button3_Click(object sender, System.EventArgs e)//Сортировка
        {
            WeatherDataGrid.DataSource = _weather.Weathers.OrderBy(i => i.Temperature).ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _weather.Weathers.Where(i => i.CityName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    WeatherDataGrid.DataSource = _weather.Weathers.Where(i => i.MeasureUnit == MeasureUnits.Celsius).ToList();
                    break;
                case 1:
                    WeatherDataGrid.DataSource = _weather.Weathers.Where(i => i.MeasureUnit == MeasureUnits.Fahrenheit).ToList();
                    break;
                case 2:
                    WeatherDataGrid.DataSource = _weather.Weathers.Where(i => i.MeasureUnit == MeasureUnits.Kelvin).ToList();
                    break;
            }
        }
    }
}