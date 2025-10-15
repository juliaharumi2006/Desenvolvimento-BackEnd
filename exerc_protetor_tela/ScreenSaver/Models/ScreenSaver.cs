namespace Models.Screens;

using Models.BaseShapes;
using System.Drawing;
using System.Windows.Forms;

public class ScreenSaver : Form
{
    // ******* Declare suas formas geométricas aqui (escopo global) *******
    MyRectangle r;

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
            
            // ***********************************************
            Invalidate(); // Foça a tela a ser redesenhada.
        }; // Função anônima disparada pelo ControlTimer a cada Interval (ms)
        ControlTimer.Start();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        // ****** Instancie suas formas geométricas aqui ******
        r = new MyRectangle(0, 0, Color.Red, 200, 100);
        // ****************************************************
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // ****** Desenhe suas formas geométricas aqui *******
        r.Draw(e.Graphics);
        // ***************************************************

    }
}