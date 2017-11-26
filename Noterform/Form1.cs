using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Telegram;


namespace Noterform
{
    public partial class Form1 : Form
    {

        System.Globalization.PersianCalendar cal = new System.Globalization.PersianCalendar();
        int count = 0;

        public string shw_date()
        {
           // System.Globalization.PersianCalendar cal = new System.Globalization.PersianCalendar();
            string year = cal.GetYear(DateTime.Now).ToString();
            string monthe = cal.GetMonth(DateTime.Now).ToString();
            string day = cal.GetDayOfMonth(DateTime.Now).ToString();

            return year + "/" + monthe + "/" + day;
        }
        public void s(string usr_text, string message)
        {
            string id = bot.chat_id;
            string mes_id = bot.message_id;
            if (bot.message_text.Contains(usr_text))
            {
                bot.sendMessage.reply_to_message(id, message, mes_id);
            }
            
                
        }


        //public string shw_time()
        //{

        //    string 
        //}



        private void QWE()
            {
                while (true)
                {
                    Thread.Sleep(5);
                }
            }
            private void ALI()
            {
                while (true)
                {
                    Thread.Sleep(50);

                }
            }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Telegram.bot bot = new Telegram.bot();
            bot.token = "477046326:AAEdQeL1TZw_sUg4QUZOmwz8pVrEnoj-xqE";
            bot.update = "true";
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
            ThreadStart ts = new ThreadStart(QWE);
            Thread TRD = new Thread(ts);
            TRD.Start();
            ThreadStart ts1 = new ThreadStart(ALI);
            Thread TRD1 = new Thread(ts1);
            TRD1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            while (true)
            {
                Telegram.bot.update = "true";
                textBox2.Text = bot.update;
                textBox1.Text = count.ToString();
               
                if (bot.message_text != "")
                {
                    count++;

                    if (bot.message_text.Contains("به تو چه"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "bi adab nabash 😐", bot.message_id);

                    }
                    else if (bot.message_text.Contains("😂😂"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "inghad nakhand yekammam gerye kon😐", bot.message_id);
                    }
                    else if (bot.message_text.Contains("😂"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "nakhand 😐", bot.message_id);
                    }
                    else if (bot.message_text.Contains("😐"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "asan to shakhi😐", bot.message_id);
                    }
                    if (bot.message_text.Contains("😡"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "khobe khobe 😐", bot.message_id);
                    }
                    if (bot.message_text.Contains("😏"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "heh!", bot.message_id);
                    }
                    else if (bot.message_text.Contains("?"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "inja uni nist ke soal miporsi 😐", bot.message_id);
                    }
                    else if (bot.message_text.Contains("😳"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "😐😐😐چیه بابا ", bot.message_id);
                    }
                    else if (bot.message_text.Contains("@"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "😐😐😐تبلیغ نکن  ", bot.message_id);

                    }

                    else if (bot.message_text.Contains("😂😂😂"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "بخند تا دنیا بروت بخنده  ", bot.message_id);

                    }
                    else if (bot.message_text.Contains("😂😂😂😂"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "با دیوار که نیستم..میگم نخند :/  ", bot.message_id);

                    }
                    if (bot.message_text.Contains("خفه"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "😱😱😱😱😱گفتی خفه..زنگ بزنم بابات ؟", bot.message_id);
                    }
                    else if (bot.message_text.Contains("پیشرفته"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "تو مبانی پاس کردی حرف از پیشرفته میزنی😏😏 ", bot.message_id);
                    }
                    else if (bot.message_text.Contains("😌"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "هیچ وقت مغرور نباش " +  Environment.NewLine + "هیچ وقت..", bot.message_id);
                    }

                    else if (bot.message_text.Contains("خیلی"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "#اصیل_تر_صحبت_کنیم" + Environment.NewLine + "بجاش بگو بسیار", bot.message_id);
                    }
                    else if (bot.message_text.Contains("😍"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, " ", bot.message_id);
                    }
                    if (bot.message_text.Contains("❤️"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "آرمان های امام رَ حفظ کن", bot.message_id);
                    }
                    else if (bot.message_text.Contains("خدافظ"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "نرووووووووو😭😭😭😭", bot.message_id);
                    }
                    if (bot.message_text.Contains("😭"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "گریه نکن که اشکات..(افرین خوب داری میخونی..ادامه بده..تو خوانندگی استعداد داری)", bot.message_id);
                    }
                    if (bot.message_text.Contains("شوخی"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "مگه من با تو شوخی دارم ", bot.message_id);
                    }
                    if (bot.message_text.Contains("لفت"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "بخدا اگه لفت بدی رگمو میزنم😭😭😭😭😭😭😭😭😭😭😭😭😭😭😭😭😭😭 ", bot.message_id);
                    }
                    if (bot.message_text.Contains("😀"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "خوشحال باش..میگذره", bot.message_id);
                    }
                    if (bot.message_text.Contains("😔"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "نبینم غمتو😢😢😢😢 ", bot.message_id);
                    }
                    if (bot.message_text.Contains("سلام"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "😃😃 سلام😃😃 منکه چطورم..تو چطوری؟؟ ", bot.message_id);
                    }

                    if (bot.message_text.Contains("شب بخیر"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "ستاره بچینی ..خدافظ", bot.message_id);
                    }
                    if (bot.message_text.Contains("چندمه"))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, shw_date(), bot.message_id);
                    }

                    if (bot.message_text == "تاریخ")
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, shw_date(), bot.message_id);
                    }
                    if (bot.message_text.Contains("جالب"))
                    {

                        bot.sendMessage.reply_to_message(bot.chat_id, "جالب میدونی چیه؟"+Environment.NewLine+"امروز "+cal.GetDayOfYear(DateTime.Now).ToString()+"امین روز سال هست !!  "/*+ cal.GetYear(DateTime.Now).ToString()*/, bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                     {
                        s("خوبی؟", "ممنون تو چطوری ؟😍😍😍");
                    }
                    if (bot.message_text.Contains(""))
                    {
                        s("چخبر", "سلامتی رهبر");
                    }
                    /* if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }
                    if (bot.message_text.Contains(""))
                    {
                        bot.sendMessage.reply_to_message(bot.chat_id, "", bot.message_id);
                    }  */






                }
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(count.ToString());
        }
    }
}
