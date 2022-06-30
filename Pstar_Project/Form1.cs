namespace Pstar_Project
{
    public partial class Form1 : Form
    {
        Graphics g;

        // 게임실행 화면
        int formW = 300;
        int formH = 500;

        // 공
        Rectangle ball;
        int ballW = 10;
        int ballH = 10;

        // 공의 움직임
        double slope = 0.1;
        double dir = 1;
        Random random = new Random();

        // 라켓
        Rectangle racket = new Rectangle();
        int racketY = 479;
        int racketW = 50;
        int racketH = 10;

        // 블록
        Rectangle[] blocks = new Rectangle[100];
        bool[] blockVisible = new bool[100];

        int blockY = 60;
        int blockW = 30;
        int blockH = 20;


        // //////////////////////////////w볼, 라켓, 블록 속성////////////////////////////////
        public void InitBall()
        {
            ball = new Rectangle(formW / 2 - ballW / 2,
                                 blockY + 20 / 10 * blockH,
                                 ballW,
                                 ballH);
        }

        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        public void InitBlocks()
        {
            for (int i = 0; i < 20; i++)
            {
                blocks[i] = new Rectangle(i % 10 * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW - 1,
                                          blockH - 1);
            }
        }

        public void InitblockVisible()
        {
            for (int i = 0; i < 20; i++)
            {
                blockVisible[i] = true;
            }
        }
        // //////////////////////////////////////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();

            // 게임 실행기 크기
            ClientSize = new Size(formW, formH);
            this.Text = "BlockBreak v1.0";
            g = CreateGraphics();
            InitRacket();
            InitBall();
            InitBlocks();
            InitblockVisible();

        }

        // 그리기 도구 생성
        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Black);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < 20; i++)
            {
                if (blockVisible[i])
                {
                    g.FillRectangle(blockColor, blocks[i]);
                }
            }

            // 라켓 그리기
            g.FillRectangle(racketColor, racket);
            
            // 공 그리기
            g.FillRectangle(ballColor, ball);
            g.DrawRectangle(pen, ball);
        }

        private void Tm_Tick(object sender, EventArgs e)
        {

        }
    }
}