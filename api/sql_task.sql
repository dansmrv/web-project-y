SELECT 
'{' +
'"Id:"' + CONVERT(NVARCHAR(50), Id) + ',' +
'"Number:"' + CONVERT(NVARCHAR(50), Number) + ',' +
'"Type:"' + CONVERT(NVARCHAR(50), Type) + ',' +
'"Length:"' + CONVERT(NVARCHAR(50), Length) + ',' + 
'"Width:"' + CONVERT(NVARCHAR(50), Width) + ',' +
'"Height:"' + CONVERT(NVARCHAR(50), Height) + ',' +
'"Weight:"' + CONVERT(NVARCHAR(50), Weight) + ',' +
'"IsEmpty:"' + CONVERT(NVARCHAR(50), IsEmpty) + ',' +
'"ArrivingDate:"' + CONVERT(NVARCHAR(50), ArrivingDate, 126) + '"' +
'}' AS JSONContainer

FROM Containers;



SELECT 
'{' +
'"Id:"' + CONVERT(nvarchar(50),Id) +',' +
'"ContainerId:"' + CONVERT(NVARCHAR(50), ContainerId) + ',' +
'"StartDate:"' + CONVERT(NVARCHAR(50), StartDate) + ',' +
'"EndDate:"' + CONVERT(NVARCHAR(50), EndDate) + ',' +
'"OperationType:"' +  OperationType + ',' +
'"OperatorFullName:"' + OperatorFullName + ',' +
'"InspectionPlace:"' +  InspectionPlace + '"' +
'}' AS JSONOperations


FROM Operations;