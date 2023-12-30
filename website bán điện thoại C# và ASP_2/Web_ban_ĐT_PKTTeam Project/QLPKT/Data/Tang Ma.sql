GO
if exists (select * from sysobjects WHERE name = 'fn_NextID' AND type = 'fn')
    drop function fn_NextID
GO
-- @lastid là mã cuối cùng (fixwidth)
-- @prefix là tiền tố mã: vd HS0001 => HS
-- @size là số lượng ký tự trong mã HS0001 => 6
CREATE function fn_NextID (@lastid varchar(10),@prefix varchar(10),@size int)
  returns varchar(10)
as
    BEGIN
        IF(@lastid = '')
            set @lastid = @prefix + REPLICATE (0,@size - LEN(@prefix))
        declare @num_nextid int, @nextid varchar(10)
        set @lastid = LTRIM(RTRIM(@lastid))
        -- number next id
        set @num_nextid = replace(@lastid,@prefix,'') + 1
        -- bo di so luong ky tu tien to
        set @size = @size - len(@prefix)
        -- replicate số lượng số 0 REPLICATE(0,3) => 000
        set @nextid = @prefix + REPLICATE (0,@size - LEN(@prefix))
        set @nextid = @prefix + RIGHT(REPLICATE(0, @size) + CONVERT (VARCHAR(MAX), @num_nextid), @size)
        return @nextid
    END;
    



GO
if exists (select * from sysobjects WHERE name = 'tr_NextID_Test' AND type = 'TR')
    drop trigger tr_NextID_Test
GO
create trigger tr_NextID_Test on KhachHang
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MaKH from KhachHang order by MaKH desc)
        UPDATE KhachHang set MaKH = dbo.fn_NextID (@lastid,'HS',7) where MaKH = ''
    end
    
insert into KhachHang (MaKH,HoTen) values ('','vfdsfv')