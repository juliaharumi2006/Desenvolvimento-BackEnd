    namespace Models.Screens;

    using Models.BaseShapes;
    using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;

    public class ScreenSaver : Form
    {
        // ******* Declare suas formas geométricas aqui (escopo global) *******
        MyRectangle r, r2, s1;

        // ********************************************************************
        private Timer ControlTimer;

        public ScreenSaver()
        {
            this.DoubleBuffered = true;                     // evita flickering
            this.WindowState = FormWindowState.Maximized;   // Maximiza a janela
            this.BackColor = Color.Black;                   // Define a cor de background                  
            ControlTimer = new Timer();                     // Inicializa o temporizador de controle
            ControlTimer.Interval = 16;                     // 16 ms = ~60 fps
            ControlTimer.Tick += (s, e) =>                  // Controle da animação
            {
                // ****** Mova suas formas geométricas aqui ******
                r.Move(ClientSize.Width, ClientSize.Height);
                r2.Move(ClientSize.Width, ClientSize.Height);
                s1.Move(ClientSize.Width, ClientSize.Height);
                // ***********************************************
                Invalidate(); // Foça a tela a ser redesenhada.
            }; // Função anônima disparada pelo ControlTimer a cada Interval (ms)
            ControlTimer.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
        base.OnLoad(e);
        // ****** Instancie suas formas geométricas aqui ******
        r = new MyRectangle(0, 0, 200, 100);
        r2 = new MyRectangle(ClientSize.Width, ClientSize.Height);
        s1 = new MySquare(ClientSize.Width, ClientSize.Height);
            
            // ****************************************************
        }

        protected override void OnPaint(PaintEventArgs e)
        {
        base.OnPaint(e);
        // ****** Desenhe suas formas geométricas aqui *******
        r.Draw(e.Graphics);
        r2.Draw(e.Graphics);
        s1.Draw(e.Graphics);
            // ***************************************************

        }
    }