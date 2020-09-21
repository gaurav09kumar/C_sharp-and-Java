--create transaction in SQL Sever
Begin Transaction

BEGIN TRY
	INSERT INTO Orders (OrderId,Amount, CustomerId)
	VALUES(8,500.00, 3);

	--SCOPE_IDENTITY() will return the identity of the record recently inserted from the same scope & same session
	DECLARE @OrderId int
	SET @OrderId = SCOPE_IDENTITY()

	SELECT * FROM Orders where OrderId=@OrderId;

	COMMIT
END TRY
BEGIN CATCH
	ROLLBACK
END CATCH