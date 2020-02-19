using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using back_end.Models;

namespace back_end.Managers
{
    public class OrderManager
    {
      private const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SupermarketDB;Integrated Security=True";
      private SqlConnection connection;
      public UserManager()
      {
          connection = new SqlConnection(connectionString);
      }
      public string PutFeedback(OrderFeedbackModel model)
      {
          string feedback=model.Feedback;
          try
          {
              connection.Open();
              using (SqlCommand cmd = new SqlCommand())
              {
                  cmd.Connection = connection;
                  cmd.CommandText = string.Format("Update Orders set Feedback='{0}' where Id= '{1}')", model.Feedback, model.Id);
                  cmd.ExecuteNonQuery();
              }
          }
          catch
          {
              throw;
          }
          finally
          {
              connection.Close();
          }
          return feedback;
      }
   }
}
