USE ProjectManager
 CREATE TABLE [dbo].[PROJECT]
(
    [PROJECT_ID] INT NOT NULL PRIMARY KEY IDENTITY , 
    [PROJECT_NAME] VARCHAR(255) NOT NULL, 
    [PROJECT_STATUS] VARCHAR(20) NOT NULL, 
    [PROJECT_PRIORITY] VARCHAR(50) NOT NULL, 
    [PROJECT_START_DATE] DATETIME NOT NULL, 
    [PROJECT_END_DATE] DATETIME NULL, 
    [PROJECT_GROUP_ID] INT NOT NULL,
    [PROJECT_CREATOR_ID] INT NOT NULL,
    [PROJECT_DESCRIPTION] VARCHAR(500) NULL,
)

  CREATE TABLE [dbo].[TASK]
(
    [TASK_ID] INT NOT NULL PRIMARY KEY IDENTITY , 
    [TASK_NAME] VARCHAR(255) NOT NULL ,
    [TASK_STATUS] VARCHAR(20) NOT NULL,
    [TASK_PRIORITY] VARCHAR(50) NOT NULL,
    [TASK_START_DATE] DATETIME NOT NULL,
    [TASK_END_DATE] DATETIME NULL,
    [TASK_OWNER_ID] INT NOT NULL,
    [TASK_CREATOR_ID] INT NOT NULL,
    [TASK_PROJECT_ID] INT NOT NULL,
    [TASK_GROUP_ID] INT NULL ,
    [TASK_DESCRIPTION] VARCHAR(255) NULL,
	[TASK_BADGES] VARCHAR(150) NOT NULL,
)

  CREATE TABLE [dbo].[USER]
(
    [USER_ID] INT NOT NULL IDENTITY, 
    [USER_NAME] VARCHAR(255) NOT NULL, 
    [USER_SURNAME] VARCHAR(20) NOT NULL, 
    [USER_MAIL] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [USER_ROLE] VARCHAR(50) NULL,
    [USER_PASSWORD] VARCHAR(50) NOT NULL, 
    [USER_REGISTER_DATE] DATETIME NULL, 
    [USER_LAST_LOGIN_DATE] DATETIME NULL, 
    [USER_SECRET_WORD] VARCHAR(50) NOT NULL,
)

 CREATE TABLE [dbo].[LOG]
(
    [LOG_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LOG_SOURCE] VARCHAR(50) NULL,
    [LOG_TYPE] VARCHAR(50) NOT NULL, 
    [LOG_DATE] DATETIME NOT NULL,
    [LOG_USER] VARCHAR(50) NULL,
    [LOG_USER_ID] INT NULL,
    [LOG_DESCRIPTION] VARCHAR(255) NULL,
    [LOG_STATUS] VARCHAR(50) NULL,
)

CREATE TABLE [dbo].[GROUP]
(
    [GROUP_ID] INT NOT NULL PRIMARY KEY IDENTITY,
    [GROUP_NAME] VARCHAR(50) NOT NULL,
    [GROUP_FOUNDER_ID] INT NOT NULL,
    [GROUP_MANAGER_ID] INT NOT NULL,
    [GROUP_DESCRIPTION] VARCHAR(100) NULL,
    [GROUP_FORMATION_DATE] DATETIME NOT NULL,
	[GROUP_STATUS] VARCHAR(50) NOT NULL,
)

CREATE TABLE [dbo].[USER_GROUP]
(
    [USER_GROUP_ID] INT NOT NULL PRIMARY KEY IDENTITY,
    [USER_ID] INT NOT NULL ,
    [GROUP_ID] INT NOT NULL ,
    [USER_GROUP_AUTHORIZATION] INT NOT NULL, -- //3 - owner / 2 - admin / 1 - member / 0 - viewer (invited)
    [INVITE_DATE] DATETIME NULL,
    [PROCESS_DATE] DATETIME NULL,
    [INVITE_SENDER_ID] INT NOT NULL,
    [INVITE_STATUS] VARCHAR(50) NOT NULL, -- // -Rejected -Accepted -Waiting --Kicked --Left
)


UPDATE [GROUP] SET GROUP_STATUS='Active'

 SELECT COUNT(LOG_USER) FROM LOG_DATA WHERE LOG_USER='a.hakan1818@hotmail.com'

 SELECT (SELECT COUNT(PROJECT_ID) FROM PROJECT) AS project_count, (SELECT COUNT(TASK_ID) FROM TASK) AS task_count;

 INSERT INTO [USER_GROUP] (USER_ID,GROUP_ID,USER_GROUP_AUTHORIZATION,INVITE_DATE,PROCESS_DATE,INVITE_SENDER_ID,INVITE_STATUS) 
					VALUES(1,4,2,CURRENT_TIMESTAMP,null,4,'Accepted')