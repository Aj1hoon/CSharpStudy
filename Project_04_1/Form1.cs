namespace Project_04_1
{
    public partial class Form1 : Form
    {
        Graphics g;
        int formW = 300;
        int formH = 500;
        Rectangle racket;
        int racketW = 50;    //라켓의 폭
        int racketH = 10;
        int racketY = 479;    //라켓의 초기 높이 좌표


        Rectangle[] blocks = new Rectangle[20];
        int blockW = 30;
        int blockH = 20;
        int blockY = 60;

        Rectangle ball;
        int ballW = 10;
        int ballH = 10;

        bool[] bVisible = new bool[20];
        Timer t;
        SoundPlayer soundWall;   //벽
        SoundPlayer soundRacket; //라켓
        SoundPlayer soundBlock; //블록
        SoundPlayer soundDie; //죽었을때

        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(formW, formH);
            Text = "Block Breaker 0.1";
            g = this.CreateGraphics();

            //라켓 만들기
            InitRacket();

            //블록 만들기
            InitBlocks();

            //공만들기
            InitBall();


            //bVisible[] 초기화

            for (int i = 0; i < 20; i++)
                bVisible[i] = true;

            //타이머만들기
            t = new Timer();
            t.Interval = 100;   //0.1초
            t.Start();
            t.Tick += T_Tick;

            //공의 기울기 세팅
            //InitBall
        }
        double xDir = -1;  //0.5~2.0사이의 값으로하자
        int yDir = 1;

        private int deadBall = 0;
        private int clearedBlocks = 0; //없어진 블록의 수
        private void T_Tick(object sender, EventArgs e)
        {
            //좌우 벽에 맞았을 때 처리
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
            //라켓, 블록, 천장에 맞았을 때 처리
            ball.Y += yDir * 10;
            //라켓에 맞으면
            if (ball.IntersectsWith(racket))
            {
                yDir *= -1;
                soundRacket.Play();
            }
            //천장에 맞으면
            if (ball.Y <= 0)
            {
                yDir *= -1;
                soundWall.Play();
            }
            //블록을 맞으면
            for (int i = 0; i < 20; i++)
                if (bVisible[i] == true && ball.IntersectsWith(blocks[i]))
                {
                    yDir *= -1;
                    bVisible[i] = false;
                    clearedBlocks++;
                    if (clearedBlocks == 20)
                    {
                        t.Stop();
                        DialogResult x = MessageBox.Show("Mission Completed !", "경기종료",
                             MessageBoxButtons.YesNo);
                        if (x == DialogResult.Yes)
                        {
                            deadBall = 0;
                            clearedBlocks = 0;
                            InitBall();                       //공위치도 초기화
                            InitBlocks();                      //블록도 초기화
                            InitRacket();              //라켓도초기화
                            t.Start();                   //시간다시시작
                            for (int y = 0; y < 20; y++)
                                bVisible[y] = true;
                            t.Start();
                        }
                        else Close();
                    }
                    soundBlock.Play();
                }
            //죽었을 때
            if (ball.Y >= formH)
            {
                soundDie.Play();
                if (++deadBall >= 3)
                {
                    t.Stop();                       //시간을 멈추고
                    DialogResult x =
                         MessageBox.Show("One more Time?", "Gameover!",
                         MessageBoxButtons.YesNo);    //한번더? 게임오버! 메세지
                    if (x == DialogResult.Yes)
                    {
                        //초기화가 필요한 부분
                        deadBall = 0;
                        clearedBlocks = 0;
                        InitBall();                       //공위치도 초기화
                        InitBlocks();                      //블록도 초기화
                        InitRacket();              //라켓도초기화
                        t.Start();                   //시간다시시작
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
            //기울기
            xDir = r.Next(5, 20) / 10.0;
            //출발 방향
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
        private void InitRacket()               //라켓값세팅
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
        //라켓의 움직임 : 화살표 처리
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)//왼쪽키보드이면
            {
                racket.X -= 10;
                if (racket.X < 0) //화면밖으로 나가는거 방지
                    racket.X = 0;
            }
            else if (e.KeyCode == Keys.Right) //오른쪽
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
            Invalidate(); //Paint event를 만들어준다
        }
    }
   

    }