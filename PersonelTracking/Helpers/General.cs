using System.Media;
using SysTask = System.Threading.Tasks.Task;

namespace PersonelTracking.Helpers;

    
public class General
{
    public static bool isNumber(TextBox useridTxt, KeyPressEventArgs e, string placeholderTxt)
    {
        if (useridTxt.Text == placeholderTxt)
        {
            return true; // or false based on behavior needed
        }

        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // <- THIS BLOCKS the character from being typed
            useridTxt.ForeColor = Color.Lime; // optional visual cue
            return true;
        }

        return false;
    }

    public static void isAnyText(TextBox UserInput, string placeholderTxt)
    {
        if (UserInput.Text == placeholderTxt)
        {
            UserInput.Clear();
            UserInput.ForeColor = Color.Lime;
            return;
        }
        else {
            return;
        }
    }

    public static void isUserIdText(TextBox UserInput, string placeholderTxt)
    {
            if (UserInput.Text == placeholderTxt)
            {
                UserInput.Clear();
                UserInput.ForeColor = Color.Lime;
            return;
            }
        else
            return;
        
    }

    public static void isDateText(TextBox UserInput, KeyPressEventArgs e, string placeholderTxt)
    {
        // If placeholder is still there, clear on first key press and change color
        if (UserInput.Text == placeholderTxt)
        {
            UserInput.Clear();
            UserInput.ForeColor = Color.Lime;
        }

        // Allow control keys (backspace etc)
        if (char.IsControl(e.KeyChar))
            return;

        // Allow digits
        if (char.IsDigit(e.KeyChar))
            return;

        // Allow slash
        if (e.KeyChar == '/')
            return;

        // Block anything else
        e.Handled = true;
    }

    public static void isPasswordText(TextBox PasswordInputBox, KeyEventArgs e)
    {
                    {
            if (PasswordInputBox.Text == "Password")
            {
                PasswordInputBox.Clear();
                PasswordInputBox.ForeColor = Color.Lime;
                PasswordInputBox.PasswordChar = '*';
                e.Handled = true;
                return; // Let KeyDown handle Enter fully
            }

            e.Handled = false; // Allow valid typing
        }
    }

    public static void styleTextBox(TextBox tb)
    {
        tb.ForeColor = Color.Lime;
        tb.BackColor = Color.Black;

        Font silkscreenFont = new Font("Silkscreen", 10, FontStyle.Bold);
        tb.Font = silkscreenFont;
    }
    public static void styleRichTextBox(RichTextBox rtb)
    {
        rtb.ForeColor = Color.Lime;
        rtb.BackColor = Color.Black;

        Font silkscreenFont = new Font("Silkscreen", 10, FontStyle.Bold);
        rtb.Font = silkscreenFont;
    }


    public static void StyleDataGridView(DataGridView dgv) //style every data grid view.
    {
        //Colors
        dgv.BackgroundColor = Color.Black;
        dgv.ForeColor = Color.Lime;
        dgv.GridColor = Color.Green;
        dgv.DefaultCellStyle.BackColor = Color.Black;
        dgv.DefaultCellStyle.ForeColor = Color.Lime;
        dgv.DefaultCellStyle.SelectionBackColor = Color.Lime;
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        // Set font on BOTH header and cells
        Font silkscreenFont = new Font("Silkscreen", 12, FontStyle.Bold);
        dgv.ColumnHeadersDefaultCellStyle.Font = silkscreenFont;
        dgv.DefaultCellStyle.Font = silkscreenFont;

        dgv.EnableHeadersVisualStyles = false;
        dgv.AllowUserToResizeColumns = false;
        dgv.AllowUserToResizeRows = false;

        dgv.BorderStyle = BorderStyle.None;
        dgv.RowHeadersVisible = false;
    }

    public static void PlaySound(string soundFileName)
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", soundFileName);

            using (SoundPlayer player = new SoundPlayer(path))
            {
                player.Play(); // .PlaySync() if you want to wait
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to play sound: {ex.Message}");
        }
    }

    public static Random rnd = new Random(); //Random

    public static string[] MouseClickSounds = new string[] //list of mouse click sounds
    {
    "ClickArray/Click_Mouse_Button_01.WAV",
    "ClickArray/Click_Mouse_Button_02.WAV",
    "ClickArray/Click_Mouse_Button_03.WAV",
    "ClickArray/Click_Mouse_Button_04.WAV",
    "ClickArray/Click_Mouse_Button_05.WAV",
    "ClickArray/Click_Mouse_Button_06.WAV",
    "ClickArray/Click_Mouse_Button_07.WAV",
    "ClickArray/Click_Mouse_Button_08.WAV",
    "ClickArray/Click_Mouse_Button_09.WAV",
    "ClickArray/Click_Mouse_Button_010.WAV"
    };

    public static string[] keyDownSounds = new string[] //list of mouse click sounds
    {
        "KeyArray/MechanicalKeyboard_01.wav",
        "KeyArray/MechanicalKeyboard_02.wav",
        "KeyArray/MechanicalKeyboard_03.wav",
        "KeyArray/MechanicalKeyboard_04.wav",
        "KeyArray/MechanicalKeyboard_05.wav",
        "KeyArray/MechanicalKeyboard_06.wav",
        "KeyArray/MechanicalKeyboard_07.wav",
        "KeyArray/MechanicalKeyboard_08.wav",
        "KeyArray/MechanicalKeyboard_09.wav",

    };



    public static void PlayRandomMouseClickSound() //Pick and play a random sound
    {
        int index = rnd.Next(MouseClickSounds.Length); // pick random index
        PlaySound(MouseClickSounds[index]);
    }

    public static void PlayRandomKeyDownSounds()
    {
        int index = rnd.Next(keyDownSounds.Length); //pick random index
        PlaySound(keyDownSounds[index]);
    }

    public static class ComboBoxStyleHelper
    {
        public static void ApplyCMBUniversalStyle(ComboBox combo)
        {
            // Background color when enabled
            combo.BackColor = Color.Black; // Example black background

            // Foreground text color
            combo.ForeColor = Color.Lime; // Example green text

            // Dropdown style (Optional)
            combo.DropDownStyle = ComboBoxStyle.DropDownList; // Forces selection only

            // Flat style (Optional)
            combo.FlatStyle = FlatStyle.Flat;

            // Font (Optional)
            combo.Font = new Font("Silkscreen", 12, FontStyle.Bold);
        }

        public static void ApplyCMBDisabledStyle(ComboBox combo)
        {
            combo.BackColor = Color.DarkGray;
            combo.ForeColor = Color.WhiteSmoke;
            combo.Font = new Font("Silkscreen", 12, FontStyle.Bold);
        }
    }

    public static class Textboxhelper
    { 
    public static void ApplyTextBoxStyle(TextBox text)
    {
        text.BackColor = Color.Black;
        text.ForeColor = Color.Lime;
        text.Font = new Font("Silkscreen", 12, FontStyle.Bold);
    }

    }

    public static async void UserMessage(Label LabelName,string Message, Color TextColor, string Sound)
    {
        LabelName.Text = Message;
        LabelName.ForeColor = TextColor;
        //Play Error sound
        PlaySound(Sound);

        await SysTask.Delay(2000); // Short delay to clear lblsaved text.
        LabelName.Text = "";

    }

    public static DialogResult YNCheck(string Message, MessageBoxButtons YNSelect)
    {
        return MessageBox.Show(Message, "Warning", YNSelect);
    }
}