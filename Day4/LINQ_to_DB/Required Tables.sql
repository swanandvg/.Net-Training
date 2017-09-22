create table BranchInfo
(
	branchNo int primary key,
	branchName varchar(20),
	branchCity varchar(20)
)
insert into BranchInfo values(10,'Marathalli','Bangalore')
insert into BranchInfo values(20,'Hi-Tech','Hyderabad')
insert into BranchInfo values(30,'Bandra','Mumbai')


create table AccountDetail
(
	accNo int primary key,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accBranch int,
	constraint fk_branchNo foreign key (accBranch) references BranchInfo)

	insert into AccountDetail values(1,'Iron Man','Savings',5000,10)
	insert into AccountDetail values(2,'Captain America','Current',5000,20)
	insert into AccountDetail values(3,'Spider Man','Savings',5000,30)
	insert into AccountDetail values(4,'Thor','Savings',5000,20)
	insert into AccountDetail values(5,'Black Widow','Current',5000,30)
	insert into AccountDetail values(6,'Hawk Eye','Current',5000,10)
	insert into AccountDetail values(7,'The Vision','Savings',5000,20)
	insert into AccountDetail values(8,'Scarlett Witch','Current',5000,10)
	insert into AccountDetail values(9,'Falcon','Savings',5000,10)
	insert into AccountDetail values(10,'Iron Patriot','Current',5000,30)


	create procedure updateBalance
	as
	begin
		update AccountDetail set accBalance = accBalance + 200
	end

	----------

	create procedure sp_deleteAccount(@accNo int)
	as
	begin
		delete from AccountDetail where accNo = @accNo
	end

	----------
	create procedure sp_newAccount(@accNo int output, @accName varchar(20),@accType varchar(20),
									@accBalance int,@accBranch int)
	as
	begin
		set @accNo = (select max(accNo) + 1 from AccountDetail)
		insert into AccountDetail values(@accNo,@accName,@accType,@accBalance,@accBranch)
	end