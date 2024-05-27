using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data;

namespace WebApplication
{
    public class SMTP_Client
    {
        SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
        
        public string send(Model model, String predictedHtmlTable, String username, String password, String ToUser)
        {
            try
            {
                MailMessage mail = new MailMessage();

                string body = $@"
    <html>
    <body>
        <h2>Chi tiết nhân viên</h2>
        <p>Age: {model.Age}</p>
        <p>Distance From Home: {model.DistanceFromHome}</p>
        <p>Education: {model.Education}</p>
        <p>Percent Salary Hike: {model.PercentSalaryHike}</p>
        <p>Total Working Years: {model.TotalWorkingYears}</p>
        <p>Years At Company: {model.YearsAtCompany}</p>
        <p>Years In Current Role: {model.YearsInCurrentRole}</p>
        <p>Years Since Last Promotion: {model.YearsSinceLastPromotion}</p>
        <p>Years With Current Manager: {model.YearsWithCurrManager}</p>
        
        <h2>Bảng truy vấn</h2>
        {predictedHtmlTable}
    </body>
    </html>";

                mail.From = new MailAddress(username);
                mail.To.Add(ToUser);
                mail.Subject = "Phân tích dữ liệu";
                mail.Body = body;
                mail.IsBodyHtml = true;

                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(username, password);
                client.EnableSsl = true;

                client.Send(mail);

                return "Mail gửi thành công!!";

            }catch (Exception ex)
            {
                String mess = ex.ToString();
                return mess;
            }
            
        }
    }
}