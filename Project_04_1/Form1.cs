namespace Project_04_1
{
    public partial class Form1 : Form
    {
        Graphics g;
        int formW = 300;
        int formH = 500;
        Rectangle racket;
        int racketW = 50;    //������ ��
        int racketH = 10;
        int racketY = 479;    //������ �ʱ� ���� ��ǥ


        Rectangle[] blocks = new Rectangle[20];
        int blockW = 30;
        int blockH = 20;
        int blockY = 60;

        Rectangle ball;
        int ballW = 10;
        int ballH = 10;

        bool[] bVisible = new bool[20];
        Timer t;
        SoundPlayer soundWall;   //��
        SoundPlayer soundRacket; //����
        SoundPlayer soundBlock; //���
        SoundPlayer soundDie; //�׾�����

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(formW, formH);
            Text = "Block Breaker 0.1";
            g = this.CreateGraphics();

            //���� �����
            InitRacket();

            //��� �����
            InitBlocks();

            //�������
            InitBall();


            //bVisible[] �ʱ�ȭ

            for (int i = 0; i < 20; i++)
                bVisible[i] = true;

            //Ÿ�̸Ӹ����
            t = new Timer();
            t.Interval = 100;   //0.1��
            t.Start();
            t.Tick += T_Tick;

            //���� ���� ����
            //InitBall
        }
        double xDir = -1;  //0.5~2.0������ ����������
        int yDir = 1;

        private int deadBall = 0;
        private int clearedBlocks = 0; //������ ����� ��
        private void T_Tick(object sender, EventArgs e)
        {
            //�¿� ���� �¾��� �� ó��
            ball.X += (int)(xDir * 10);
            ball.Y += yDir * 10;

            if (ball.X >= formW - ballW)
            {
                xDir *= -1;
                soundWall.Play();

            }
            else if (ball.X <= 0)
            {
                xDir *= -1;
                soundWall.Play();
            }
            //����, ���, õ�忡 �¾��� �� ó��
            ball.Y += yDir * 10;
            //���Ͽ� ������
            if (ball.IntersectsWith(racket))
            {
                yDir *= -1;
                soundRacket.Play();
            }
            //õ�忡 ������
            if (ball.Y <= 0)
            {
                yDir *= -1;
                soundWall.Play();
            }
            //����� ������
            for (int i = 0; i < 20; i++)
                if (bVisible[i] == true && ball.IntersectsWith(blocks[i]))
                {
                    yDir *= -1;
                    bVisible[i] = false;
                    clearedBlocks++;
                    if (clearedBlocks == 20)
                    {
                        t.Stop();
                        DialogResult x = MessageBox.Show("Mission Completed !", "�������",
                             MessageBoxButtons.YesNo);
                        if (x == DialogResult.Yes)
                        {
                            deadBall = 0;
                            clearedBlocks = 0;
                            InitBall();                       //����ġ�� �ʱ�ȭ
                            InitBlocks();                      //��ϵ� �ʱ�ȭ
                            InitRacket();              //���ϵ��ʱ�ȭ
                            t.Start();                   //�ð��ٽý���
                            for (int y = 0; y < 20; y++)
                                bVisible[y] = true;
                            t.Start();
                        }
                        else Close();
                    }
                    soundBlock.Play();
                }
            //�׾��� ��
            if (ball.Y >= formH)
            {
                soundDie.Play();
                if (++deadBall >= 3)
                {
                    t.Stop();                       //�ð��� ���߰�
                    DialogResult x =
                         MessageBox.Show("One more Time?", "Gameover!",
                         MessageBoxButtons.YesNo);    //�ѹ���? ���ӿ���! �޼���
                    if (x == DialogResult.Yes)
                    {
                        //�ʱ�ȭ�� �ʿ��� �κ�
                        deadBall = 0;
                        clearedBlocks = 0;
                        InitBall();                       //����ġ�� �ʱ�ȭ
                        InitBlocks();                      //��ϵ� �ʱ�ȭ
                        InitRacket();              //���ϵ��ʱ�ȭ
                        t.Start();                   //�ð��ٽý���
                        for (int i = 0; i < 20; i++)
                            bVisible[i] = true;
                        t.Start();
                    }
                    else if (x == DialogResult.No)
                        this.Close();

                }
                else
                    InitBall();
            }


            Invalidate();
        }
        private void InitBall()
        {
            ball = new Rectangle(formW / 2 - ballW / 2, blockY + 2 * blockH,
                ballW, ballH);

            Random r = new Random();
            //����
            xDir = r.Next(5, 20) / 10.0;
            //��� ����
            if (r.Next(2) % 2 == 0)
                xDir *= -1;
        }
        private void InitBlocks()
        {
            for (int i = 0; i < 20; i++)
            {

                blocks[i] = new Rectangle(blockW * (i % 10),
                    blockY + blockH * (i / 10), blockW - 1, blockH - 1);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawRacket();
            DrawBlocks();
            DrawBall();
        }
        private void DrawBall()
        {
            g.FillEllipse(Brushes.Gold, ball);
            g.DrawEllipse(new Pen(Color.Black), ball);
        }
        private void DrawBlocks()
        {
            for (int i = 0; i < 20; i++)
            {
                if (bVisible[i] == true)
                {
                    Rectangle r = new Rectangle();
                    r = blocks[i];
                    r.Width = blockW;
                    r.Height = blockH;
                    g.FillRectangle(Brushes.Orange, blocks[i]);
                }
            }
        }
        private void InitRacket()               //���ϰ�����
        {
            racket = new Rectangle(formW / 2 - racketW / 2, racketY,
                racketW, racketH);
            //racket.Width = racketW;
            //racket.Height = racketH;
            //racket.X = formW / 2 - racketW / 2;
            //racket.Y = racketY;
        }
        private void DrawRacket()
        {
            g.FillRectangle(Brushes.Red, racket);
        }
        //������ ������ : ȭ��ǥ ó��
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)//����Ű�����̸�
            {
                racket.X -= 10;
                if (racket.X < 0) //ȭ������� �����°� ����
                    racket.X = 0;
            }
            else if (e.KeyCode == Keys.Right) //������
            {
                racket.X += 10;
                if (racket.X > formW - racketW)
                    racket.X = formW - racketW;
            }
            else if (e.KeyCode == Keys.Up)
            {
                racket.Y -= 10;
                if (racket.Y < blockY + 2 * blockH)
                    racket.Y = blockY + 2 * blockH;
            }
            else if (e.KeyCode == Keys.Down)
            {
                racket.Y += 10;
                if (racket.Y > racketY)
                    racket.Y = racketY;
            }
            else if (e.KeyCode == Keys.Escape)
                t.Stop();
            else if (e.KeyCode == Keys.Enter)
                t.Start();
            Invalidate(); //Paint event�� ������ش�
        }
    }
   

    }