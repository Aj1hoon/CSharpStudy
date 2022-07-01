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


        double slope = -1; // ����
        int yDir = 1;  // ���� ������(���Ʒ�)

        bool[] blockVisible = new bool[20];
        

        private int deadBall = 0;
        private int clearedBlocks = 0; // ������ ����� ��


        public Form1()
        {
            InitializeComponent();

            // �� ������
            ClientSize = new Size(formW, formH);
            Text = "BlockBreak v1.0";

            // �׷��� ��ü ����
            g = this.CreateGraphics();

            // ��� �ʱ�ȭ
            InitBlocks();

            // ���� �ʱ�ȭ
            InitRacket();

            // �� �ʱ�ȭ
            InitBall();

            // blockVisible[] �ʱ�ȭ
            for (int i = 0; i < 20; i++)
                blockVisible[i] = true;
        }

        // ���, ����, �� ���ȭ
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

            // ���� ��
            slope = rand.Next(5, 20) / 10.0;

            // ��� ����
            if(rand.Next(2) % 2 == 0)
                {
                    slope *= -1;
                }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ���� �׸���
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

            // ���� �׸���
            g.FillRectangle(racketColor, racket);

            // �� �׸���
            g.FillEllipse(ballColor, ball);
            g.DrawEllipse(pen, ball);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            ball.X += (int)(slope * 10);
            ball.Y += yDir * 10;

            // ball�� �¿� ���� �浹 �ߴ��� üũ
            if (ball.X >= formW - ballW)
            {
                slope *= -1;
            }
            else if (ball.X <= 0)
            {
                slope *= -1;
            }

            // ball�� ����, õ��, ��Ͽ� �¾��� ��
            ball.Y += yDir * 10;

            // 1. ball�� ���Ͽ� �¾Ҵ��� üũball.Y += yDir * 10;
            if (ball.IntersectsWith(racket))
            {
                yDir *= -1;
            }

            // ball�� õ�忡 ������
            if (ball.Y <= 0)
            {
                yDir *= -1;
            }

            // ball�� �ν��� �� ������ �¾Ҵ��� üũ
            for (int i = 0; i < 20; i++)
                if (blockVisible[i] == true && ball.IntersectsWith(blocks[i]))
                {
                    yDir *= -1;
                    blockVisible[i] = false;
                    clearedBlocks++;
                }

            // ball�� �������� ������ ��
            if (ball.Y > ClientSize.Height)
            {
                myTimer.Stop();

                DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "Ȯ��", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    InitBlocks();
                    InitRacket();
                    InitBall();

                    // ���� �ٽ� ����
                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }

            }
            // ��� ������ �� �ν�����
            Invalidate();
        }


        // ������ ������
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;
                if (racket.X < 0) // ȭ�� �ȿ� ���α�
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