using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext =  new UserCenterEntities())
            {
                //var objectContext = (dbContext as IObjectContextAdapter).ObjectContext;
                ////dbContext.Configuration.ProxyCreationEnabled = true;
                //var userEntity = dbContext.UserTables.FirstOrDefault<UserTable>();
                ////Console.WriteLine(userEntity.GetType());
                ////Console.WriteLine(ObjectContext.GetObjectType(userEntity.GetType()));
                //Console.WriteLine(userEntity.User_ID);

                //UPDATE
                //userEntity.User_EnName = "Joy";
                //dbContext.SaveChanges();

                //DELETE
                //dbContext.UserTables.Remove(userEntity);
                //dbContext.SaveChanges();

                //INSERT
                //dbContext.SystemCodes.Add(new SystemCode { Sys_Code="Branch",Sys_Name= "学校代码",Sys_ItemValue= "17204",Sys_ItemName="毛毛幼兒園" });
                //dbContext.SaveChanges();  


                //var query = from ut in dbContext.UserTables
                //           where ut.User_NO == "0110110001"
                //           select ut;

                //var user = query.FirstOrDefault<UserTable>();
                //Console.WriteLine("user id:{0},user name:{1}", user.User_NO, user.User_EnName);


                //Like
                //var query = from ut in dbContext.UserTables
                //            where ut.User_NO.Contains("01101100")
                //            select ut;

                //Console.WriteLine("query count:{0}",query.Count());
                //foreach (var user in query)
                //{
                //    Console.WriteLine("user id:{0},user name:{1}", user.User_NO, user.User_EnName);
                //}

                //List<UserTable> users = new List<UserTable>();
                //users = query.ToList();

                //Console.WriteLine("query count:{0}", users.Count());
                //foreach (var user in users)
                //{
                //    Console.WriteLine("user id:{0},user name:{1}", user.User_NO, user.User_EnName);
                //}

                //inner Join
                //var query = from ar in dbContext.Area_Rule
                //            join
                //            ut in dbContext.UserTables on ar.Area_User_NO equals ut.User_NO
                //            join
                //            sc in dbContext.SystemCodes on ar.Area_School_TypeID equals sc.Sys_ItemValue
                //            where sc.Sys_Code == "School_TypeID"
                //            orderby ar.Area_User_NO ascending
                //            select (new
                //            {
                //                Area_School_TypeID = ar.Area_School_TypeID,
                //                Sys_ItemName = sc.Sys_ItemName,
                //                Area_User_NO = ar.Area_User_NO,
                //                User_EnName = ((ut.User_EnName == null) ? "" : ut.User_EnName)
                //            });

                //Console.WriteLine("query count:{0}", query.Count());
                //foreach (var area in query)
                //{
                //    Console.WriteLine("Area_School_TypeID:{0},Sys_ItemName:{1},Area_User_NO:{2},User_EnName:{3}",
                //        area.Area_School_TypeID,
                //        area.Sys_ItemName,
                //        area.Area_User_NO,
                //        area.User_EnName);
                //}

                //outjoin 
                //var query = from ar in dbContext.Area_Rule
                //            join ut in dbContext.UserTables on ar.Area_User_NO equals ut.User_NO into ar_ut
                //            from ut in ar_ut.DefaultIfEmpty()
                //            select new { ar.Area_School_TypeID, ar.Area_User_NO, User_EnName = ((ut.User_EnName == null) ? "" : ut.User_EnName) };



                //Console.WriteLine("query count:{0}", query.Count());
                //foreach (var area in query)
                //{
                //    Console.WriteLine("Area_School_TypeID:{0},Area_User_NO:{1},User_EnName:{2}",
                //        area.Area_School_TypeID,
                //        area.Area_User_NO,
                //        area.User_EnName);
                //}


                var query = from ar in dbContext.Area_Rule
                            join ut in dbContext.UserTables on ar.Area_User_NO equals ut.User_NO into ar_ut
                            from ut in ar_ut.DefaultIfEmpty()
                            join sc in dbContext.SystemCodes on ar.Area_School_TypeID equals sc.Sys_ItemValue
                            where sc.Sys_Code == "School_TypeID"
                            select new { ar.Area_School_TypeID, sc.Sys_ItemName, ar.Area_User_NO, User_EnName = ((ut.User_EnName == null) ? "" : ut.User_EnName) };

                Console.WriteLine("query count:{0}", query.Count());
                foreach (var area in query)
                {
                    Console.WriteLine("Area_School_TypeID:{0},Sys_ItemName:{1},Area_User_NO:{2},User_EnName:{3}",
                        area.Area_School_TypeID,
                        area.Sys_ItemName,
                        area.Area_User_NO,
                        area.User_EnName);
                }
            }
            Console.ReadLine();
        }
    }
}
