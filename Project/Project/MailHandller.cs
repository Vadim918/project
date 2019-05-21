using System.Net;
using System.Net.Mail;

namespace Project
{
    class MailHandller 
    {
       

        public static void MesHandler(string @for,int res)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("vad.sharp.91@gmail.com");
            // кому отправляем           
                MailAddress to = new MailAddress(@for);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            
          
            {
                // тема письма
                m.Subject = "Доставка пиццы";
                // текст письма
                m.Body = $"Ваш заказ готовиться,сумма для оплаты: {res} \n Будем рады видеть вас ещё в нашем приложении";

            }

            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("vad.sharp.91@gmail.com", "8529433w");
            smtp.EnableSsl = true;
            smtp.Send(m);           
        }
        
    }
}
