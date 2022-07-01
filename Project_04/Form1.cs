namespace Project_04
{
    public partial class Form1 : Form
    {
        Graphics g;

        int formW = 300;
        int formH = 500;

        Brush racketColor = new SolidBrush(Color.Red);
        Brush blockColor = new SolidBrush(Color.Black);
        Brush ballColor = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);


        Rectangle racket = new Rectangle();
        int racketY = 479;
        int racketW = 50;
        int racketH = 10;

        Rectangle[] blocks = new Rectangle[100];
        int blockY = 60;
        int blockW = 30;
        int blockH = 20;

        Rectangle ball;
        int ballW = 10;
        int ballH = 10;


        double slope = -1; // 기울기
        int yDir = 1;  // 공의 움직임(위아래)

        bool[] blockVisible = new bool[20];
        

        private int deadBall = 0;
        private int clearedBlocks = 0; // 없어진 블록의 수


        public Form1()
        {
            InitializeComponent();

            // 폼 사이즈
            ClientSize = new Size(formW, formH);
            Text = "BlockBreak v1.0";

            // 그래픽 객체 생성
            g = this.CreateGraphics();

            // 블록 초기화
            InitBlocks();

            // 라켓 초기화
            InitRacket();

            // 공 초기화
            InitBall();

            // blockVisible[] 초기화
            for (int i = 0; i < 20; i++)
                blockVisible[i] = true;
        }

        // 블록, 라켓, 공 모듈화
        public void InitBlocks()
        {
            for (int i = 0; i < 20; i++)
            {
                blocks[i] = new Rectangle((i % 10) * blockW,
                                          blockY + blockH * (i / 10),
                                          blockW-1,
                                          blockH-1);
            }

        }

        public void InitRacket()
        {
            racket.X = formW / 2 - racketW / 2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        public void InitBall()
        {
            ball = new Rectangle(formW / 2 - ballW / 2,
                                 blockY + 20 / 10 * blockH,
                                 ballW,
                                 ballH);

            Random rand = new Random();

            // 기울기 값
            slope = rand.Next(5, 20) / 10.0;

            // 출발 방향
            if(rand.Next(2) % 2 == 0)
                {
                    slope *= -1;
                }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 벽돌 그리기
            for (int i = 0; i < 20; i++)
            {
                if (blockVisible[i] == true)
                {
                    g.FillRectangle(blockColor, blocks[i]);
                }
            }
            // g.FillRectangle(blockColor, blocks[0]);
            // g.FillRectangle(blockColor, blocks[1]);
            // g.FillRectangle(blockColor, blocks[2]);
            // g.FillRectangle(blockColor, blocks[3]);

            // 라켓 그리기
            g.FillRectangle(racketColor, racket);

            // 공 그리기
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            ball.X += (int)(slope * 10);
            ball.Y += yDir * 10;

            // ball이 좌우 벽에 충돌 했는지 체크
            if (ball.X >= formW - ballW)
            {
                slope *= -1;
            }
            else if (ball.X <= 0)
            {
                slope *= -1;
            }

            // ball이 라켓, 천장, 블록에 맞았을 때
            ball.Y += yDir * 10;

            // 1. ball이 라켓에 맞았는지 체크ball.Y += yDir * 10;
            if (ball.IntersectsWith(racket))
            {
                yDir *= -1;
            }

            // ball이 천장에 맞으면
            if (ball.Y <= 0)
            {
                yDir *= -1;
            }

            // ball이 부숴야 할 벽돌을 맞았는지 체크
            for (int i = 0; i < 20; i++)
                if (blockVisible[i] == true && ball.IntersectsWith(blocks[i]))
                {
                    yDir *= -1;
                    blockVisible[i] = false;
                    clearedBlocks++;
                }

            // ball을 라켓으로 놓쳤을 때
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop();

                DialogResult result = MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitBlocks();
                    InitRacket();
                    InitBall();

                    // 게임 다시 시작
                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }

            }
            // 모든 벽돌을 다 부쉈을때
            Invalidate();
        }


        // 라켓의 움직임
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
                if (racket.X < 0) // 화면 안에 가두기
                    racket.X = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
                if (racket.X > formW - racketW)
                    racket.X = formW - racketW;
            }
            Invalidate();
        }
    }
}