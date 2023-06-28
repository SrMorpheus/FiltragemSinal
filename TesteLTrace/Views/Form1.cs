using System.Windows.Forms.DataVisualization.Charting;
using TesteLTrace.Controller;
using TesteLTrace.Models;
using Accord.Audio.Formats;

using Accord.Audio.Filters;
using Accord.Audio;
using System;

namespace TesteLTrace
{
    public partial class Form1 : Form
    {

        private readonly Chart _waveformChart;
        private readonly ControllerGrafico _controllerGrafico;
        private readonly ControllerFiltro _controllerFiltro;
        private int _lowPass;
        private int _highaPass;
        private double[] _filteredAmplitudes;
        public Form1()
        {
            InitializeComponent();

            _waveformChart = new Chart();
            _controllerGrafico = new ControllerGrafico();
            _controllerFiltro = new ControllerFiltro();

            _waveformChart.Dock = DockStyle.Fill;
            Controls.Add(_waveformChart);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            _waveformChart.ChartAreas.Add(("Filtragem de sinal"));
            _waveformChart.ChartAreas[0].AxisY.Title = "Tempo (Ms)";
            _waveformChart.ChartAreas[0].AxisX.Title = "Amplitude";

            var baseGrafico = _controllerGrafico.GetDadosId();
            var original = GraficoOriginal(baseGrafico);
            var filtrado = GraficoFiltrado(baseGrafico, _lowPass, _highaPass);
            CriarGrafico(original);

        }



        public void CriarGraficoFiltrado(Series linhaOriginal, Series linhaFiltrada)
        {
            _waveformChart.Series.Add(linhaOriginal);
            _waveformChart.Series.Add(linhaFiltrada);
            _waveformChart.Show();

        }


        public void CriarGrafico(Series linhaOriginal)
        {
            _waveformChart.Legends.Add(new Legend("Legenda"));
            _waveformChart.Series.Add(linhaOriginal);
            _waveformChart.Show();

        }



        private Series GraficoOriginal(List<ModelGrafico> dadosGraficos)
        {


            int tempoFixo = 0;

            // Criar a série do gráfico
            Series LinhaOriginal = new Series("Sísmica Original");
            LinhaOriginal.ChartType = SeriesChartType.Line;
            LinhaOriginal.Color = Color.Black;

            foreach (var dadoSismico in dadosGraficos)
            {

                double amplitudeAtual = dadoSismico.DadosSismico;
                LinhaOriginal.Points.AddXY(amplitudeAtual, tempoFixo);
                tempoFixo += 1 * 33;

            }



            for (int i = 0; i < dadosGraficos.Count; i++)
            {
                string valorFixo = i.ToString(); // Valor fixo para o rótulo
                CustomLabel label = new CustomLabel(i - 0.5, i + 0.5, valorFixo, 0, LabelMarkStyle.None);
                _waveformChart.ChartAreas[0].AxisX.CustomLabels.Add(label);
            }




            return LinhaOriginal;

        }


        private Series GraficoFiltrado(List<ModelGrafico> dadosGraficos, int passaBaixo, int passaAlto)
        {
            Series LinhaFiltrada = new Series("Sísmica Filtrada");
            LinhaFiltrada.ChartType = SeriesChartType.Line;
            LinhaFiltrada.Color = Color.Blue;

            // Defina as configurações do filtro
            int sampleRate = 44100; // Taxa de amostragem dos dados em Hz
            Signal signal = new Signal(1, dadosGraficos.Count, sampleRate, SampleFormat.Format32BitIeeeFloat);

            for (int i = 0; i < dadosGraficos.Count; i++)
            {
                signal.SetSample(0, i, (float)dadosGraficos[i].DadosSismico);
            }

            // Aplicar o filtro Passa-baixo
            LowPassFilter lowPassFilter = new LowPassFilter(passaBaixo, signal.SampleRate);
            _filteredAmplitudes = lowPassFilter.Apply(signal).ToDouble();

            // Aplicar o filtro Passa-Alta
            HighPassFilter highPassFilter = new HighPassFilter(passaAlto, signal.SampleRate);
            _filteredAmplitudes = highPassFilter.Apply(signal).ToDouble();

            for (int i = 0; i < _filteredAmplitudes.Length; i++)
            {
                LinhaFiltrada.Points.AddXY(_filteredAmplitudes[i], i * 33);
            }

            return LinhaFiltrada;

        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


            var numero = textBox1.Text;

            int numeroInt;

            var boolValor = int.TryParse(numero, out numeroInt);


            if (boolValor)
            {

                _lowPass = numeroInt;

            }
            else
            {

                _lowPass = 1;


            }

        }





        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var numero = textBox3.Text;

            int numeroInt;

            var boolValor = int.TryParse(numero, out numeroInt);


            if (boolValor)
            {

                _highaPass = numeroInt;

            }
            else
            {

                _highaPass = 1;


            }

            textBox3.TextChanged += (sender, e) =>
            {

                AtualizarGrafico();

            };
        }


        private void AtualizarGrafico()
        {

            var baseGrafico = _controllerGrafico.GetDadosId();
            var original = GraficoOriginal(baseGrafico);
            var filtrado = GraficoFiltrado(baseGrafico, _lowPass, _highaPass);

            _waveformChart.Series.Clear();
            CriarGraficoFiltrado(original, filtrado);

            _waveformChart.Update();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_lowPass == 0 && _highaPass == 0 || _lowPass == 1 && _highaPass == 1 || _lowPass == 0 && _highaPass == 1 || _lowPass == 1 && _highaPass == 0)
            {

                string message = "Operação não permitida";
                string caption = "Filtro não permitido para salvar!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

            }

            else
            {
                ModelFiltro filtro = new ModelFiltro(_lowPass, _highaPass);
                _controllerFiltro.SalvarDados(filtro);
                _controllerGrafico.SalvarVariosDados(_filteredAmplitudes, filtro.Id);

                string caption = "Filtragem Sísmica";
                string message = "Savo com sucesso!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);


            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
