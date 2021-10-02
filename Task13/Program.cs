using System;
using System.Data;
using System.IO;
using System.Reflection;

namespace Task13
{
    internal class Program
    {
        // Проведите рефакторинг - https://gist.github.com/HolyMonkey/adcf9478bd6dcdd21384bf269155f8fe


        private DataTable GetPassportDataTable(string passportSerialAndNumber)
        {
            string commandText = string.Format("select * from passports where num='{0}' limit 1;",
                        (object)Form1.ComputeSha256Hash(passportSerialAndNumber));
            string connectionString = string.Format("Data Source=" +
                                                    Path.GetDirectoryName(Assembly.GetExecutingAssembly()
                                                        .Location) + "\\db.sqlite");
            try
            {
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                connection.Open();
                SQLiteDataAdapter sqLiteDataAdapter =
                    new SQLiteDataAdapter(new SQLiteCommand(commandText, connection));
                DataTable dataTable1 = new DataTable();
                DataTable dataTable2 = dataTable1;
                sqLiteDataAdapter.Fill(dataTable2);

                connection.Close();
                return dataTable1;
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode != 1)
                    MessageBox.Show("Ошибка доступа к базе.");
                else
                    MessageBox.Show("Файл db.sqlite не найден. Положите файл в папку вместе с exe.");
            }

            throw new ArgumentException(nameof(passportSerialAndNumber));
        }
        
        
        private void TryAccessBulletinButton_Click(object sender, EventArgs e)
        {
            string passportSerialAndNumber = this.passportTextbox.Text.Trim().Replace(" ", string.Empty);
            
            if (string.IsNullOrEmpty(passportSerialAndNumber))
                MessageBox.Show("Введите серию и номер паспорта");
            else if (passportSerialAndNumber.Length < 10)
                this.textResult.Text = "Неверный формат серии или номера паспорта";
            else
            {
                DataTable passportDataTable = GetPassportDataTable(passportSerialAndNumber);
                    
                if (passportDataTable.Rows.Count > 0)
                {
                    if (Convert.ToBoolean(passportDataTable.Rows[0].ItemArray[1]))
                        this.textResult.Text = "По паспорту «" + this.passportTextbox.Text +
                                               "» доступ к бюллетеню на дистанционном электронном голосовании ПРЕДОСТАВЛЕН";
                    else
                        this.textResult.Text = "По паспорту «" + this.passportTextbox.Text +
                                               "» доступ к бюллетеню на дистанционном электронном голосовании НЕ ПРЕДОСТАВЛЯЛСЯ";
                }
                else
                    this.textResult.Text = "Паспорт «" + this.passportTextbox.Text +
                                           "» в списке участников дистанционного голосования НЕ НАЙДЕН";
            }
            
            
        }

        public static void Main(string[] args)
        {
        }
    }
}