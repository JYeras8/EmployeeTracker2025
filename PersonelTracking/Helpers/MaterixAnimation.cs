using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public class MatrixAnimation
{
    private readonly RichTextBox _outputBox;
    private readonly System.Windows.Forms.Timer _timer;

    private readonly char[] _charset;
    private readonly Random _rand = new Random();

    private int _columns;
    private int _rows;
    private char[,] _grid;
    private int[] _columnHeads;

    public MatrixAnimation(RichTextBox outputBox, int width, int height, int speed = 50)
    {
        _outputBox = outputBox;

        _columns = (width - 10) / 12; // adjust for right padding
        _rows = height / 20;

        _charset = GetCharset();
        _grid = new char[_rows, _columns];
        _columnHeads = new int[_columns];

        for (int i = 0; i < _columns; i++)
            _columnHeads[i] = _rand.Next(_rows);

        _timer = new System.Windows.Forms.Timer();
        _timer.Interval = speed;
        _timer.Tick += (s, e) => Update();

        Update(); // Draw first frame immediately
    }

    private char[] GetCharset()
    {
        string pool = "ｱｲｳｴｵｶｷｸｹｺｻｼｽｾｿﾀﾁﾂﾃﾄABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return pool.ToCharArray();
    }

    private string EscapeRTFChar(char ch)
    {
        return ch switch
        {
            '\\' => "\\\\",
            '{' => "\\{",
            '}' => "\\}",
            _ => ch.ToString() + " "
        };
    }

    private void Update()
    {
        var rtf = new StringBuilder();
        rtf.Append(@"{\rtf1\ansi\deff0{\colortbl;\red50\green205\blue50;\red34\green139\blue34;\red0\green100\blue0;}\fs20");

        for (int x = 0; x < _columns; x++)
        {
            int headY = _columnHeads[x];
            int clearY = (headY + 4) % _rows;
            _grid[clearY, x] = ' ';
            _grid[headY, x] = _charset[_rand.Next(_charset.Length)];
            _columnHeads[x] = (headY + 1) % _rows;
        }

        for (int y = 0; y < _rows; y++)
        {
            for (int x = 0; x < _columns; x++)
            {
                char ch = _grid[y, x];
                if (ch == ' ')
                {
                    rtf.Append("  ");
                }
                else
                {
                    int head = _columnHeads[x];
                    int distance = (y - head + _rows) % _rows;

                    if (distance == 0)
                        rtf.Append("\\cf1 ");
                    else if (distance == 1)
                        rtf.Append("\\cf2 ");
                    else
                        rtf.Append("\\cf3 ");

                    rtf.Append(EscapeRTFChar(ch));
                }
            }
            rtf.Append("\\line ");
        }

        rtf.Append("}");
        try
        {
            _outputBox.Rtf = rtf.ToString();
        }
        catch
        {
            _outputBox.Text = "";
        }
    }

    public void Start() => _timer.Start();
    public void Stop() => _timer.Stop();
}
