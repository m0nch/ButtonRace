using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveButton
{
    public partial class RaceForm : Form
    {
        Thread threadBella, threadAlex, threadLady;
        static readonly object locker = new object();
        public RaceForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            threadBella = new Thread(new ParameterizedThreadStart(ChangePosition)) { Name = "Bella" };
            threadBella.Start(btnBella);
            threadAlex = new Thread(new ParameterizedThreadStart(ChangePosition)) { Name = "Alex" };
            threadAlex.Start(btnAlex);
            threadLady = new Thread(new ParameterizedThreadStart(ChangePosition)) { Name = "Lady" };
            threadLady.Start(btnLady);
        }

        private void ChangePosition(object btn)
        {
            Button _btn = (Button)btn;

            while (_btn.Location.X + _btn.Size.Width < PanelFinish.Location.X)
            {
                Invoke((MethodInvoker)delegate
                {
                    Random rnd = new Random();
                    int x = rnd.Next(10, 100);
                    Thread.Sleep(400);
                    _btn.Location = new Point(_btn.Location.X + x, _btn.Location.Y);
                });
            }
            lock (locker)
            {
                MessageBox.Show($"The winner is { _btn.Name }", "Winner Information");

                string name = Thread.CurrentThread.Name;
                if (name == "Bella")
                {
                    threadAlex.Abort();
                    threadLady.Abort();
                }
                else if (name == "Alex")
                {
                    threadBella.Abort();
                    threadLady.Abort();
                }
                else if (name == "Lady")
                {
                    threadBella.Abort();
                    threadAlex.Abort();
                }
            }
            Reset();
        }

        private void Reset()
        {
            Invoke((MethodInvoker)delegate
            {
                btnBella.Location = new Point(27, btnBella.Location.Y);
                btnAlex.Location = new Point(27, btnAlex.Location.Y);
                btnLady.Location = new Point(27, btnLady.Location.Y);
            });
        }

    }
}
