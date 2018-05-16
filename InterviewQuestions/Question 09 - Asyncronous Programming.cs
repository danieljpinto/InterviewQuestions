﻿using System;
using System.Threading.Tasks;
namespace InterviewQuestions
{
    /// <summary>
    /// What will happen when I execute the DoWork method? write your answer below
    /// 
    /// 
    /// Answer:
    /// an async task will run that will be executed potentially before the result has been fetched. The user here should either turn DoWork into an async method and await GetObjectByIdAsync
    /// Or they should add a new line in line 26 saying dbObject.Wait();
    /// 
    /// </summary>
    public class Question9
    {
        private readonly IRepository<DatabaseObject> _database;

        private Question9(IRepository<DatabaseObject> database)
        {
            _database = database;
        }

        public void DoWork()
        {
            var dbObject = GetObjectByIdAsync(5);
            DoMoreWork(dbObject.Result);
        }

        private void DoMoreWork(DatabaseObject obj)
        {
            throw new NotImplementedException();
        }

        private async Task<DatabaseObject> GetObjectByIdAsync(int id)
        {
            var dbObject = await _database.GetObjectFromDatabaseAsync(id);
            return dbObject;
        }

        private interface IRepository<T>
        {
            Task<T> GetObjectFromDatabaseAsync(int id);
        }

        private class DatabaseObject
        {
            public int Id { get; set; }
        }
    }
}
