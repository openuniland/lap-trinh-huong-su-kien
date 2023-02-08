create database btl_hsk
use btl_hsk

create table tbl_HangDT
(
	iMahangDT int not null primary key,
	sTenhangDT varchar(50)
)


create table tbl_Dienthoai
(
	sMaDT varchar(10) not null,
	iMahangDT int,
	sTenDT varchar(50),
	iSoluong int,
	iGiaban int
)


alter table tbl_Dienthoai
add constraint PK_tblSanpham primary key(sMaDT)

alter table tbl_Dienthoai
add constraint FK_mahangdt_Dienthoai foreign key(iMahangDT) references tbl_HangDT(iMahangDT)

Create table tbl_Nhanvien(
iMaNV int not null,
sTenNV varchar(30) not null,
sDiachi varchar(50) not null,
dNgaysinh datetime,
sSdt varchar(11),
fLuongCB float,
fPhuCap float,
Constraint PK_tblNhanvien Primary key (iMaNV));

create table tbl_khachhang
(
	sMaKH varchar(10) not null primary key,
	sTenkhachhang varchar(50),
	dNgaysinh date,
	sDiachi varchar(50),
	sGioitinh varchar(10),
	sSdt varchar(10)
)

create table tbl_DatHang
(
	sMadathang varchar(10) not null primary key,
	sMaKH varchar(10),
	iMaNV int,
	dNgaydat date,
	iTongtien int
)

alter table tbl_DatHang
add constraint FK_khachhang_Dathang foreign key(sMaKH) references tbl_khachhang(sMaKH)

alter table tbl_DatHang
add constraint FK_mNhanVien_Dathang foreign key (iMaNV) references tbl_Nhanvien(iMaNV);

create table tbl_Chitietdathang
(
	sMactdh varchar(10) not null primary key,
	sMadathang varchar(10),
	sMaDT varchar(10),
	iSoluong int,
	iGiaban int
)

alter table tbl_Chitietdathang
add constraint FK_dathang_CTDathang foreign key(sMadathang) references tbl_DatHang(sMadathang)

alter table tbl_Chitietdathang
add constraint FK_madt_CTDathang foreign key(sMaDT) references tbl_Dienthoai(sMaDT)

-- thuc hien voi bang dien thoai---
-- insert hang dien thoai
insert into tbl_HangDT
values(0, 'Iphone')

insert into tbl_HangDT
values(1, 'Samsung')

insert into tbl_HangDT
values(2, 'Vsmart')

insert into tbl_HangDT
values(3, 'Xiaomi')

select * from tbl_HangDT
-- insert bang san pham--

insert into tbl_Dienthoai
values('DT1',1,'IPhone13',22000000,25)

insert into tbl_Dienthoai
values('DT2',2,'SamSung Ultra11',23500000,30)

insert into tbl_Dienthoai
values('DT3',3,'RedMe11',8000000,22)

select * from tbl_Dienthoai

-- proc them dien thoai
create proc ThemDT (@iMahang int, @sMaDT varchar(10), @sTenDT varchar(10), @iSoluong int, @iGiaban int)
as
insert into tbl_Dienthoai(sMaDT,iMahangDT, sTenDT, iSoluong, iGiaban)
values( @sMaDT,@iMahang, @sTenDT , @iSoluong , @iGiaban )
go

select *from tbl_Dienthoai
select * from tbl_HangDT
-- proc
create proc HienDienThoai (@TenHangDT varchar(50))
as
select sMaDT as N'Ma Dien Thoai', sTenDT as N'Ten Dien Thoai', sTenhangDT as N'Ten Hang DT',
iSoluong as N'So Luong', iGiaban as N'Gia Ban' from tbl_Dienthoai
inner join tbl_HangDT
on tbl_Dienthoai.iMahangDT = tbl_HangDT.iMahangDT
where @TenHangDT = tbl_HangDT.sTenhangDT

exec HienDienThoai @TenHangDT='Samsung'

exec ThemDT @sMaDT ='ip12-001' ,@imahang = 1, @sTenDT = 'Iphone12sss' , @iSoluong = 2 , @iGiaban = 2700000

-- proc them hang dien thoai
create proc ThemHangDT(@iMahangDT int, @sTenhangDT varchar(50))
as
insert into tbl_HangDT(iMahangDT, sTenhangDT)
values(@iMahangDT, @sTenhangDT)
exec ThemHangDT @iMahangDT = 5, @sTenhangDT='Dien thoai moi'

create proc XoaDT (@sMaDT varchar(10))
as
delete from tbl_Dienthoai where sMaDT = @sMaDT

-- xoa dien thoai
exec XoaDT @sMaDT = '1'

create proc HiendsDT
as
begin
select sMaDT as [Mã điện thoại] , tbl_Dienthoai.iMahangDT as [Mã hãng điện thoại] ,tbl_HangDT.sTenhangDT as [Tên hãng ĐT],tbl_Dienthoai.sTenDT as [Tên điện thoại],tbl_Dienthoai.iSoluong as [Số lượng],tbl_Dienthoai.iGiaban as [Giá bán]
from tbl_Dienthoai inner join tbl_HangDT on tbl_Dienthoai.iMahangDT = tbl_HangDT.iMahangDT
end

-- thuc hien proc
execute HiendsDT

create proc TimkiemDienthoaitheoMa(@sMaDT varchar(10))
as
begin
	select tbl_Dienthoai.sMaDT,tbl_Dienthoai.sTenDT,tbl_Dienthoai.iGiaban
	from tbl_Dienthoai
	where tbl_Dienthoai.sMaDT=@sMaDT
end

execute TimkiemDienthoaitheoMa @sMaDT='ip11-001'
select * from tbl_Dienthoai
where sMaDT = sMaDT

select * from tbl_Dienthoai
where sMaDT = '001'

create proc suaDT (@sMaDT varchar(10), @iMaHangDT int, @sTenDT varchar(50), @iSoLuong int, @iGiaBan int)
as
begin
update tbl_Dienthoai
set iMahangDT = @iMaHangDT, sTenDT = @sTenDT, iSoluong = @iSoLuong, iGiaban = @iGiaBan
where sMaDT = @sMaDT
end

execute SuathongtinDT @sMaDT='001', @iMahangDT=0, @sTenDT='hi', @iSoluong=0, @iGiaban=0

select*from tbl_Dienthoai

create proc kiemtra (@iMahangDT int, @sMaDT varchar(10),@sTenDT varchar(50), @iSoluong int, @iGiaban int)
	as
	select * from tbl_Dienthoai
	where sMaDT=@sMaDT and iMahangDT=@iMahangDT and sTenDT=@sTenDT and iSoluong=@iSoluong and iGiaban=@iGiaban

execute kiemtra @iMahangDT=1, @sMaDT='DT1', @sTenDT='ip', @iSoluong=1, @iGiaban=1


 