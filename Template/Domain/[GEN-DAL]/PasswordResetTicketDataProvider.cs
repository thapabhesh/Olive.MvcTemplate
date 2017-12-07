﻿namespace AppData
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;
    using Olive;
    using Olive.Entities;
    using Olive.Entities.Data;
    
    /// <summary>Provides data-access facilities for Password reset tickets.</summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class PasswordResetTicketDataProvider : SqlDataProvider<Domain.PasswordResetTicket>
    {
        #region SQL Commands
        
        /// <summary>Gets a SQL command text to query a single Password reset ticket record</summary>
        
        /// <summary>Gets the list of fields to use for loading Password reset tickets.</summary>
        public override string GetFields()
        {
            return @"P.[ID] AS [PasswordResetTickets_Id],
            P.[User] AS [PasswordResetTickets_User],
            P.[DateCreated] AS [PasswordResetTickets_DateCreated],
            P.[IsUsed] AS [PasswordResetTickets_IsUsed]";
        }
        
        /// <summary>Provides the data source expression for querying Password reset ticket records.</summary>
        public override string GetTables()
        {
            return @"[PasswordResetTickets] AS P";
        }
        
        /// <summary>Gets a SQL command text to insert a record into PasswordResetTickets table.</summary>
        const string INSERT_COMMAND = @"INSERT INTO [PasswordResetTickets]
        ([Id], [User], [DateCreated], [IsUsed])
        VALUES
        (@Id, @User, @DateCreated, @IsUsed)";
        
        /// <summary>Gets a SQL command text to update a record in PasswordResetTickets table.</summary>
        const string UPDATE_COMMAND = @"UPDATE [PasswordResetTickets] SET
        [Id] = @Id,
        [User] = @User,
        [DateCreated] = @DateCreated,
        [IsUsed] = @IsUsed
        OUTPUT [INSERTED].[ID]
        WHERE [ID] = @OriginalId";
        
        /// <summary>Gets a SQL command text to delete a record from PasswordResetTickets table.</summary>
        const string DELETE_COMMAND = @"DELETE FROM [PasswordResetTickets] WHERE [ID] = @Id";
        
        #endregion
        
        /// <summary>Gets the database column name for a specified PasswordResetTicket property.</summary>
        public override string MapColumn(string propertyName) => $"P.[{propertyName}]";
        
        public override string MapSubquery(string path)
        {
            if (path == "User.*")
            {
                return @"SELECT [PasswordResetTickets_User_U].[ID]
                FROM [Users] AS PasswordResetTickets_User_U
                LEFT OUTER JOIN [Administrators] AS PasswordResetTickets_User_A
                ON PasswordResetTickets_User_A.Id = PasswordResetTickets_User_U.[ID]
                WHERE [PasswordResetTickets_User_U].[ID] = P.[User]";
            }
            
            return base.MapSubquery(path);
        }
        
        /// <summary>
        /// Lazy-loads the data for the specified many-to-many relation on the specified Password reset ticket instance from the database.<para/>
        /// </summary>
        public override Task<IEnumerable<string>> ReadManyToManyRelation(IEntity instance, string property)
        {
            throw new ArgumentException($"The property '{property}' is not supported for the instance of '{instance.GetType()}'");
        }
        
        /// <summary>Extracts the Password reset ticket instance from the current record of the specified data reader.</summary>
        public override IEntity Parse(IDataReader reader)
        {
            var result = new Domain.PasswordResetTicket();
            FillData(reader, result);
            EntityManager.SetSaved(result, reader.GetGuid(0));
            return result;
        }
        
        /// <summary>Loads the data from the specified data reader on the specified Password reset ticket instance.</summary>
        internal void FillData(IDataReader reader, Domain.PasswordResetTicket entity)
        {
            var values = new object[reader.FieldCount];
            reader.GetValues(values);
            
            entity.UserId = (Guid)values[Fields.User];
            entity.DateCreated = (DateTime)values[Fields.DateCreated];
            entity.IsUsed = (bool)values[Fields.IsUsed];
        }
        
        /// <summary>Saves the specified Password reset ticket instance in the database.</summary>
        public override async Task Save(IEntity record)
        {
            var item = record as Domain.PasswordResetTicket;
            
            if (record.IsNew)
                await Insert(item);
            else
                await Update(item);
        }
        
        /// <summary>Inserts the specified new Password reset ticket instance into the database.</summary>
        async Task Insert(Domain.PasswordResetTicket item)
        {
            await ExecuteScalar(INSERT_COMMAND, CommandType.Text,
            CreateParameters(item));
        }
        
        /// <summary>Bulk inserts a number of specified Password reset tickets into the database.</summary>
        public override async Task BulkInsert(IEntity[] entities, int batchSize)
        {
            var commands = new List<KeyValuePair<string, IDataParameter[]>>();
            
            foreach (var item in entities.Cast<Domain.PasswordResetTicket>())
            {
                commands.Add(INSERT_COMMAND, CreateParameters(item));
            }
            
            await Access.ExecuteBulkNonQueries(CommandType.Text, commands);
        }
        
        /// <summary>Updates the specified existing Password reset ticket instance in the database.</summary>
        async Task Update(Domain.PasswordResetTicket item)
        {
            if ((await ExecuteScalar(UPDATE_COMMAND, CommandType.Text, CreateParameters(item))).ToStringOrEmpty().IsEmpty())
            {
                Cache.Current.Remove(item);
                throw new ConcurrencyException($"Failed to update the 'PasswordResetTickets' table. There is no row with the ID of {item.ID}.");
            }
        }
        
        /// <summary>Creates parameters for Inserting or Updating Password reset ticket records</summary>
        IDataParameter[] CreateParameters(Domain.PasswordResetTicket item)
        {
            var result = new List<IDataParameter>();
            
            result.Add(CreateParameter("OriginalId", item.OriginalId));
            result.Add(CreateParameter("Id", item.GetId()));
            result.Add(CreateParameter("User", item.UserId));
            result.Add(CreateParameter("DateCreated", item.DateCreated, DbType.DateTime2));
            result.Add(CreateParameter("IsUsed", item.IsUsed));
            
            return result.ToArray();
        }
        
        /// <summary>Deletes the specified Password reset ticket instance from the database.</summary>
        public override async Task Delete(IEntity record)
        {
            await ExecuteNonQuery(DELETE_COMMAND, System.Data.CommandType.Text, CreateParameter("Id", record.GetId()));
        }
        
        static class Fields
        {
            public const int User = 1;
            public const int DateCreated = 2;
            public const int IsUsed = 3;
        }
    }
}