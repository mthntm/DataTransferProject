**Description:**
*Data transfer*

**Project Purpose:**
*It is to transfer the data of the related tables in Mssql to Postgresql, which hosts the related table.*

**Project features and technologies used:<br />**
*1)It is a Console application.<br />
2)Mssql and Postgresql were used as databases containing relationship tables.<br />
3)Mssql entities are created in MssqlModels with EntityFramework.Core DbFirst approach.<br />
4)Postgresql entities are created in PostgresqlModels with EntityFramework.Core CodeFirst approach.<br />*

**The following packages are downloaded into DataTransferProject with Nuget:<br />**
*1)Microsoft.EntityFrameworkCore.Design (3.1.3)<br />
2)Microsoft.EntityFrameworkCore.Relational (3.1.3)<br />
3)Microsoft.EntityFrameworkCore.SqlServer (3.1.3)<br />
4)Microsoft.EntityFrameworkCore.Tools (3.1.3)<br />*


**Warning:** 
*The 1>n relations in the table are first populated with Source (primary key part) then foreign key (n) side data.*
