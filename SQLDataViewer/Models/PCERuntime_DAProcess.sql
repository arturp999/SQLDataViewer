/****** Script for SelectTopNRows command from SSMS  ******/
USE PCERuntime

DECLARE @PROCESS VARCHAR(14);
DECLARE @CONTRACT VARCHAR(12);
DECLARE @NIF VARCHAR(10);
DECLARE @SEQNBR BIGINT

--Proposal Nbr
SET @PROCESS = '2720913'
SET @CONTRACT = ''
SET @NIF = ''
SET @SEQNBR = ''

IF @PROCESS = '' BEGIN SET @PROCESS = NULL END
IF @CONTRACT = '' BEGIN SET @CONTRACT = NULL END
IF @NIF = '' BEGIN SET @NIF = NULL END
IF @SEQNBR = '' BEGIN SET @SEQNBR = NULL END

--DAProcess
SELECT SeqNbr, ProductCode, EDFDesign_Product.Name AS Product, BizProcCode, BP.Name AS Process, BizProcNbr, Status, DAPS.Description AS StatusDesc, BranchCode, StatusDate, StatusTime, [User], UserLock, CreationDate, CreationTime, CreationUser, CustomerName, CustomerNbr, ContractNbr, Transit, EntryChannel, CentralStatus, AssociatedDAProcessSeqNbr
FROM DAProcess WITH (NOLOCK)
JOIN BizProcessType BP WITH (NOLOCK) ON DAProcess.BizProcCode = BP.Code
JOIN EDFDesign_DAProcessStatus DAPS WITH (NOLOCK) ON DAProcess.[Status] = DAPS.Code
JOIN EDFDesign_Product WITH (NOLOCK) ON DAProcess.ProductCode = EDFDesign_Product.Code
WHERE BizProcNbr = ISNULL(@PROCESS, BizProcNbr) AND SeqNbr = ISNULL(@SEQNBR, SeqNbr) AND ContractNbr = ISNULL(@CONTRACT, ContractNbr) AND CustomerNbr = ISNULL(@NIF, CustomerNbr)

 -- DAProcessDoc
 IF @PROCESS IS NOT NULL
 BEGIN
	 SELECT PD.* 
	 FROM [PCERuntime].[dbo].[DAProcessDoc] PD WITH (NOLOCK)
	 JOIN [PCERuntime].[dbo].[DAProcess] P WITH (NOLOCK) ON PD.DAProcessSeqNbr = P.SeqNbr
	 WHERE BizProcNbr = @PROCESS
 END

 --DAProcessWorkQueue
 IF @PROCESS IS NOT NULL
 BEGIN
	SELECT WQ.*  
	FROM [PCERuntime].[dbo].[DAProcessWorkQueue] WQ WITH (NOLOCK)
	JOIN [PCERuntime].[dbo].[DAProcess] P WITH (NOLOCK) ON WQ.DAProcessSeqNbr = P.SeqNbr
	WHERE BizProcNbr = @PROCESS
 END

 -- DAProcess Anomaly
 IF @PROCESS IS NOT NULL
 BEGIN
	SELECT A.*, PA.AnomalyDateTime, PA.CreationUser, PA.Resolved, PA.ResolvedDate, PA.ResolvedUser
	FROM [PCERuntime].[dbo].[DAProcessAnomaly] PA WITH (NOLOCK)
	JOIN [PCERuntime].[dbo].[Anomaly] A WITH (NOLOCK) ON PA.AnomalyCode = A.Code
	JOIN [PCERuntime].[dbo].[AnomalyType] ATP WITH (NOLOCK) ON A.AnomalyTypeCode = ATP.Code
	WHERE PA.BizProcNbr = @PROCESS
  END

--DAProcessOperation
 IF @PROCESS IS NOT NULL
 BEGIN
	SELECT DAPO.OpDate, DAPO.OpTime, DAPO.[User] AS OpUser, DAPS.Code AS OpStatusCode, DAPS.Description AS OpStatusDesc
	FROM DAProcessOperation DAPO WITH (NOLOCK)
	JOIN DAProcess DAP WITH (NOLOCK) ON DAPO.DAProcessSeqNbr = DAP.SeqNbr 
	JOIN EDFDesign_DAProcessStatus DAPS WITH (NOLOCK) ON DAPO.DAProcessStatus = DAPS.Code 
	WHERE  DAP.BizProcNbr = @PROCESS
	ORDER BY DAPO.OpDate, DAPO.OpTime
END

   -- TJ Branch
 IF @PROCESS IS NOT NULL
 BEGIN
	 SELECT UserName, ProcDate, ProcTime, Channel, Branch, TxnCode, TJ.Status, SysError, UserMsg, TxnDetail
	 FROM [ETMRuntime].[dbo].[TJ_Branch] TJ WITH (NOLOCK)
	 WHERE AcctNbr = @PROCESS
	 ORDER BY ProcDate, ProcTime
 END

    -- Process Signature
 IF @PROCESS IS NOT NULL
 BEGIN
	 SELECT PS.*
	 FROM [PCERuntime].[dbo].[DAProcessSignature] PS WITH (NOLOCK)
	 JOIN [PCERuntime].[dbo].[DAProcess] P WITH (NOLOCK) ON PS.DAProcessSeqNbr = P.SeqNbr
	 WHERE P.BizProcNbr = @PROCESS
 END