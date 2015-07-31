using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.IO;
using System.Net;

namespace sendMail
{
    public class email
    {
        public string error = null;

        /**sendMail - com cc e email oculto
         * String[] ocultos
         * String[] copia
         * String[] destinatarios
         * string caminhoAnexo
         * string corpo
         * string titulo
         * string usaurio
         * string senha
         * string servidorSMTP
         * Boolean ssl
         * int porta
         * Classe responsavel por envio de email, informa todas os detalhes no vetor dados
         **/
        public Boolean sendMail(string[] destino, string[] copia, string[] oculto, Boolean ssl, int porta, string[] caminhoAnexo, string corpo, string titulo, string usuario, string senha, string servidorSMTP)
        {
            try
            {
                //variaveis e instancias utilizadas
                MailMessage objEmail = new MailMessage();
                SmtpClient objSmtp = new SmtpClient();
                //adiciona anexo
                for(int i=0;i<=caminhoAnexo.Length;i++)
                {
                    Attachment anexo = new Attachment(caminhoAnexo[i], System.Net.Mime.MediaTypeNames.Application.Octet);
                    objEmail.Attachments.Add(anexo);
                }
                //remetente
                objEmail.From = new MailAddress(usuario);
                //destino
                for (int i = 0; i <= destino.Length; i++)
                {
                    objEmail.To.Add(destino[i]);
                }
                //copia
                for (int i = 0; i <= copia.Length; i++)
                {
                    objEmail.CC.Add(copia[i]);
                }
                //oculto
                for (int i = 0; i <= oculto.Length; i++)
                {
                    objEmail.Bcc.Add(oculto[i]);
                }
                objEmail.Priority = MailPriority.Normal;
                objEmail.IsBodyHtml = true;
                objEmail.Subject = titulo + " - " + DateTime.Now.ToShortDateString() + " (" + DateTime.Now.ToShortTimeString() + ")";
                objEmail.Body = corpo;
                objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
                objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
                //endereço smtp
                objSmtp.Host = servidorSMTP;
                //seguranla ssl
                objSmtp.EnableSsl = ssl;
                //porta de ação
                objSmtp.Port = porta;
                //email e senha remetente
                objSmtp.Credentials = new NetworkCredential(usuario, senha);
                objSmtp.Send(objEmail);
                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }
        }

         /**sendMail - com cc e email oculto
         * String[] destinatarios
         * string[] caminhoAnexo
         * string corpo
         * string titulo
         * string usaurio
         * string senha
         * string servidorSMTP
         * Boolean ssl
         * int porta
         * Classe responsavel por envio de email, informa todas os detalhes no vetor dados
         **/
        public Boolean sendMail(string[] destino, Boolean ssl, int porta, string[] caminhoAnexo, string corpo, string titulo, string usuario, string senha, string servidorSMTP)
        {
            try
            {
                //variaveis e instancias utilizadas
                MailMessage objEmail = new MailMessage();
                SmtpClient objSmtp = new SmtpClient();
                //adiciona anexo
                for (int i = 0; i <= caminhoAnexo.Length; i++)
                {
                    Attachment anexo = new Attachment(caminhoAnexo[i], System.Net.Mime.MediaTypeNames.Application.Octet);
                    objEmail.Attachments.Add(anexo);
                }
                //remetente
                objEmail.From = new MailAddress(usuario);
                //destino
                for (int i = 0; i <= destino.Length; i++)
                {
                    objEmail.To.Add(destino[i]);
                }
                objEmail.Priority = MailPriority.Normal;
                objEmail.IsBodyHtml = true;
                objEmail.Subject = titulo + " - " + DateTime.Now.ToShortDateString() + " (" + DateTime.Now.ToShortTimeString() + ")";
                objEmail.Body = corpo;
                objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
                objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
                //endereço smtp
                objSmtp.Host = servidorSMTP;
                //seguranla ssl
                objSmtp.EnableSsl = ssl;
                //porta de ação
                objSmtp.Port = porta;
                //email e senha remetente
                objSmtp.Credentials = new NetworkCredential(usuario, senha);
                objSmtp.Send(objEmail);
                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }
        }

        public Boolean sendMail(string[] destino, Boolean ssl, int porta, string corpo, string titulo, string usuario, string senha, string servidorSMTP)
        {
            try
            {
                //variaveis e instancias utilizadas
                MailMessage objEmail = new MailMessage();
                SmtpClient objSmtp = new SmtpClient();
                //remetente
                objEmail.From = new MailAddress(usuario);
                //destino
                for (int i = 0; i <= destino.Length; i++)
                {
                    objEmail.To.Add(destino[i]);
                }
                objEmail.Priority = MailPriority.Normal;
                objEmail.IsBodyHtml = true;
                objEmail.Subject = titulo + " - " + DateTime.Now.ToShortDateString() + " (" + DateTime.Now.ToShortTimeString() + ")";
                objEmail.Body = corpo;
                objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");
                objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");
                //endereço smtp
                objSmtp.Host = servidorSMTP;
                //seguranla ssl
                objSmtp.EnableSsl = ssl;
                //porta de ação
                objSmtp.Port = porta;
                //email e senha remetente
                objSmtp.Credentials = new NetworkCredential(usuario, senha);
                objSmtp.Send(objEmail);
                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }
        }
    }
}
