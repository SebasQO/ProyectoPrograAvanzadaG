namespace ProyectoPrograAvanzadaG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateEditarProductos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "RowVersion");
        }
    }
}
