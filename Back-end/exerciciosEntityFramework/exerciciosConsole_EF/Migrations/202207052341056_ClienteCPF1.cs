namespace exerciciosConsole_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClienteCPF1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "CPF");
        }
    }
}
