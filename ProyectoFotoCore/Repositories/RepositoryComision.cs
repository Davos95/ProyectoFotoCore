﻿using Microsoft.AspNetCore.Http;
using ProyectoFotoCore.Data;
using ProyectoFotoCore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

#region PROCEDURES
/*
 CREATE PROCEDURE INSERTCOMISION
(@NAME NVARCHAR(25), @DESCRIPTION TEXT, @PATH TEXT, @PRICE FLOAT)
AS
	DECLARE @ORDERCOMISION INT

	SELECT @ORDERCOMISION = COUNT(*) FROM COMISION

	SET @ORDERCOMISION = @ORDERCOMISION + 1

	INSERT INTO COMISION VALUES(@NAME,@DESCRIPTION, @ORDERCOMISION,@PRICE,@PATH)

GO

CREATE PROCEDURE GETCOMISIONS
AS
	SELECT * 
	FROM COMISION
	order by ORDERCOMISION;
GO 

CREATE PROCEDURE DELETECOMISION
(@ID INT)
AS
	DELETE FROM COMISION
	WHERE ID = @ID;
GO

    CREATE PROCEDURE MODIFYSESSION
(@ID INT, @NAME nvarchar(25), @PHOTO text, @DESCRIPTION TEXT, @PRICE float)
AS
	IF(@PHOTO IS NULL)
	BEGIN
		UPDATE COMISION
		SET NAME = @NAME,
		DESCRIPTION = @DESCRIPTION,
		PRICE = @PRICE
		WHERE ID = @ID;
	END
	ELSE
	BEGIN
		UPDATE COMISION
			SET NAME = @NAME,
			PHOTO = @PHOTO,
			DESCRIPTION = @DESCRIPTION,
			PRICE = @PRICE
			WHERE ID = @ID;
	END
GO

CREATE PROCEDURE MODIFYORDERCOMISION
(@ID INT, @ORDER INT)
AS
	UPDATE COMISION 
	SET ORDERCOMISION = @ORDER 
	WHERE ID = @ID;
GO

*/
#endregion

namespace ProyectoFotoCore.Repositories
{
    public class RepositoryComision : IRepositoryComision
    {
        IPictureManagerContext context;
        public RepositoryComision(IPictureManagerContext context)
        {
            this.context = context;
        }

        public List<COMISION> GetCOMISIONS()
        {
            var comisions = this.context.GetCOMISIONS();
            return comisions;
        }

        public COMISION GetComisionByID(int id)
        {
            var comision = this.context.GetComisionByID(id);
            return comision;
        }

        public void InsertComision(String name, String description, String folder, IFormFile image, float price)
        {
            String type = image.ContentType.Split('/')[1];
            String path = Path.Combine(folder, name + "." + type);
            System.Diagnostics.Debug.WriteLine(path);
            context.InsertComision(name, description, path, price);
        }

        public void DeleteComision(int id, String folder)
        {
            COMISION comision = GetComisionByID(id);
            String file = comision.Photo.Split('\\')[1];
            File.Delete(folder+"\\"+file);
            this.context.DeleteComision(id);
        }

        public void ModifyComision(int id, String name, String description, String folder, String image, float price)
        {
            if (image != null)
            {
                image = folder + image;
            }
            this.context.ModifyComision(id, name, image, description, price);
        }

        public void OrderComision(String [] order)
        {
            int numOrder = 0;
            foreach (String value in order)
            {
                this.context.OrderComision(int.Parse(value), numOrder);
                numOrder++;
            }
        }
    }
}
