﻿// ********************************************************************
// WARNING: This file is auto-generated from M# Model.
// and may be overwritten at any time. Do not change it manually.
// ********************************************************************

namespace MSharp
{
    using System.Runtime.CompilerServices;
    
    static partial class SchemaExtensions
    {
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> ImpersonationToken(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.ImpersonationToken, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> FirstName(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.FirstName, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> LastName(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.LastName, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> Name(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Name, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> Email(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Email, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> Password(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Password, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> Salt(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Salt, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Administrator> IsDeactivated(this ListModule<Domain.Administrator>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.IsDeactivated, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.AuditEvent> UserId(this ListModule<Domain.AuditEvent>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.UserId, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.AuditEvent> Date(this ListModule<Domain.AuditEvent>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Date, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.AuditEvent> Event(this ListModule<Domain.AuditEvent>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Event, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.AuditEvent> ItemType(this ListModule<Domain.AuditEvent>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.ItemType, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.AuditEvent> ItemId(this ListModule<Domain.AuditEvent>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.ItemId, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.AuditEvent> ItemData(this ListModule<Domain.AuditEvent>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.ItemData, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.AuditEvent> UserIp(this ListModule<Domain.AuditEvent>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.UserIp, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.ContentBlock> Key(this ListModule<Domain.ContentBlock>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Key, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.ContentBlock> Content(this ListModule<Domain.ContentBlock>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Content, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.LogonFailure> Email(this ListModule<Domain.LogonFailure>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Email, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.LogonFailure> IP(this ListModule<Domain.LogonFailure>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.IP, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.LogonFailure> Attempts(this ListModule<Domain.LogonFailure>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Attempts, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.LogonFailure> Date(this ListModule<Domain.LogonFailure>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Date, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> User(this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.User, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> DateCreated(this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.DateCreated, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> IsUsed(this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.IsUsed, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.PasswordResetTicket> IsExpired(this ListModule<Domain.PasswordResetTicket>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.IsExpired, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Settings> Name(this ListModule<Domain.Settings>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Name, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Settings> PasswordResetTicketExpiryMinutes(this ListModule<Domain.Settings>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.PasswordResetTicketExpiryMinutes, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.Settings> CacheVersion(this ListModule<Domain.Settings>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.CacheVersion, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.User> FirstName(this ListModule<Domain.User>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.FirstName, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.User> LastName(this ListModule<Domain.User>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.LastName, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.User> Name(this ListModule<Domain.User>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Name, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.User> Email(this ListModule<Domain.User>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Email, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.User> Password(this ListModule<Domain.User>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Password, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.User> Salt(this ListModule<Domain.User>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.Salt, file, line);
        
        [MethodColor("#afcd14")]
        public static PropertyFilterElement<Domain.User> IsDeactivated(this ListModule<Domain.User>.SearchComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Search(x => x.IsDeactivated, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> ImpersonationToken(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ImpersonationToken, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> FirstName(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.FirstName, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> LastName(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.LastName, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> Name(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Name, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> Email(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Email, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> Password(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Password, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> Salt(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Salt, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Administrator> IsDeactivated(this ViewModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsDeactivated, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.AuditEvent> UserId(this ViewModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.UserId, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.AuditEvent> Date(this ViewModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Date, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.AuditEvent> Event(this ViewModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Event, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.AuditEvent> ItemType(this ViewModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ItemType, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.AuditEvent> ItemId(this ViewModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ItemId, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.AuditEvent> ItemData(this ViewModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ItemData, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.AuditEvent> UserIp(this ViewModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.UserIp, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.ContentBlock> Key(this ViewModule<Domain.ContentBlock>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Key, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.ContentBlock> Content(this ViewModule<Domain.ContentBlock>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Content, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.LogonFailure> Email(this ViewModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Email, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.LogonFailure> IP(this ViewModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IP, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.LogonFailure> Attempts(this ViewModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Attempts, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.LogonFailure> Date(this ViewModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Date, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.PasswordResetTicket> User(this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.User, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.PasswordResetTicket> DateCreated(this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.DateCreated, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.PasswordResetTicket> IsUsed(this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsUsed, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.PasswordResetTicket> IsExpired(this ViewModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsExpired, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Settings> Name(this ViewModule<Domain.Settings>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Name, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Settings> PasswordResetTicketExpiryMinutes(this ViewModule<Domain.Settings>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.PasswordResetTicketExpiryMinutes, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.Settings> CacheVersion(this ViewModule<Domain.Settings>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.CacheVersion, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.User> FirstName(this ViewModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.FirstName, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.User> LastName(this ViewModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.LastName, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.User> Name(this ViewModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Name, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.User> Email(this ViewModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Email, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.User> Password(this ViewModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Password, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.User> Salt(this ViewModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Salt, file, line);
        
        [MethodColor("#afcd14")]
        public static ViewElement<Domain.User> IsDeactivated(this ViewModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsDeactivated, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> ImpersonationToken(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.ImpersonationToken, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> FirstName(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.FirstName, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> LastName(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.LastName, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> Name(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Name, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> Email(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Email, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> Password(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Password, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> Salt(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Salt, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Administrator> IsDeactivated(this ListModule<Domain.Administrator>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.IsDeactivated, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.AuditEvent> UserId(this ListModule<Domain.AuditEvent>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.UserId, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.AuditEvent> Date(this ListModule<Domain.AuditEvent>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Date, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.AuditEvent> Event(this ListModule<Domain.AuditEvent>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Event, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.AuditEvent> ItemType(this ListModule<Domain.AuditEvent>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.ItemType, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.AuditEvent> ItemId(this ListModule<Domain.AuditEvent>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.ItemId, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.AuditEvent> ItemData(this ListModule<Domain.AuditEvent>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.ItemData, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.AuditEvent> UserIp(this ListModule<Domain.AuditEvent>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.UserIp, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.ContentBlock> Key(this ListModule<Domain.ContentBlock>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Key, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.ContentBlock> Content(this ListModule<Domain.ContentBlock>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Content, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.LogonFailure> Email(this ListModule<Domain.LogonFailure>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Email, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.LogonFailure> IP(this ListModule<Domain.LogonFailure>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.IP, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.LogonFailure> Attempts(this ListModule<Domain.LogonFailure>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Attempts, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.LogonFailure> Date(this ListModule<Domain.LogonFailure>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Date, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.PasswordResetTicket> User(this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.User, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.PasswordResetTicket> DateCreated(this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.DateCreated, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.PasswordResetTicket> IsUsed(this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.IsUsed, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.PasswordResetTicket> IsExpired(this ListModule<Domain.PasswordResetTicket>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.IsExpired, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Settings> Name(this ListModule<Domain.Settings>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Name, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Settings> PasswordResetTicketExpiryMinutes(this ListModule<Domain.Settings>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.PasswordResetTicketExpiryMinutes, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.Settings> CacheVersion(this ListModule<Domain.Settings>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.CacheVersion, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.User> FirstName(this ListModule<Domain.User>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.FirstName, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.User> LastName(this ListModule<Domain.User>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.LastName, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.User> Name(this ListModule<Domain.User>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Name, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.User> Email(this ListModule<Domain.User>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Email, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.User> Password(this ListModule<Domain.User>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Password, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.User> Salt(this ListModule<Domain.User>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.Salt, file, line);
        
        [MethodColor("#0ccc68")]
        public static ViewElement<Domain.User> IsDeactivated(this ListModule<Domain.User>.ColumnComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Column(x => x.IsDeactivated, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ImpersonationToken(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ImpersonationToken, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.FirstName, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.LastName, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Name, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Email, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Password(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Password, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Salt(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Salt, file, line);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsDeactivated(this FormModule<Domain.Administrator>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsDeactivated, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement UserId(this FormModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.UserId, file, line);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement Date(this FormModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Date, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Event(this FormModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Event, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ItemType(this FormModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ItemType, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ItemId(this FormModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ItemId, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement ItemData(this FormModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.ItemData, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement UserIp(this FormModule<Domain.AuditEvent>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.UserIp, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Key(this FormModule<Domain.ContentBlock>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Key, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Content(this FormModule<Domain.ContentBlock>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Content, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(this FormModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Email, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement IP(this FormModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IP, file, line);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement Attempts(this FormModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Attempts, file, line);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement Date(this FormModule<Domain.LogonFailure>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Date, file, line);
        
        [MethodColor("#AFCD14")]
        public static AssociationFormElement User(this FormModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.User, file, line);
        
        [MethodColor("#AFCD14")]
        public static DateTimeFormElement DateCreated(this FormModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.DateCreated, file, line);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsUsed(this FormModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsUsed, file, line);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsExpired(this FormModule<Domain.PasswordResetTicket>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsExpired, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(this FormModule<Domain.Settings>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Name, file, line);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement PasswordResetTicketExpiryMinutes(this FormModule<Domain.Settings>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.PasswordResetTicketExpiryMinutes, file, line);
        
        [MethodColor("#AFCD14")]
        public static NumberFormElement CacheVersion(this FormModule<Domain.Settings>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.CacheVersion, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement FirstName(this FormModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.FirstName, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement LastName(this FormModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.LastName, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Name(this FormModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Name, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Email(this FormModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Email, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Password(this FormModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Password, file, line);
        
        [MethodColor("#AFCD14")]
        public static StringFormElement Salt(this FormModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.Salt, file, line);
        
        [MethodColor("#AFCD14")]
        public static BooleanFormElement IsDeactivated(this FormModule<Domain.User>.FieldComponents @this, [CallerFilePath] string file = null, [CallerLineNumber] int line = 0) => @this.module.Field(x => x.IsDeactivated, file, line);
    }
}