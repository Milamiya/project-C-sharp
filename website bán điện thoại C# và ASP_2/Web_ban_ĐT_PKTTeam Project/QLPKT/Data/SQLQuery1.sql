select Admin.HoTen,Manager.* from Manager join Admin 
on Admin.Manager=Manager.Manager

alter table Manager
add constraint DFq
default (N'false')
for SuaMI
	