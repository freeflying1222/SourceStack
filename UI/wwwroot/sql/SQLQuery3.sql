DROP DATABASE [17bangTest];


alter database [17bangTest]
set single_user with rollback immediate --将数据库回滚到原始配置状态



-- 将数据库备份到C盘17bang.bak
BACKUP DATABASE [17bang] TO DISK = 'G:\\17bang.bak' 
-- 根据C盘17bang.bak恢复数据库
RESTORE DATABASE [17bang] FROM DISK = 'G:\\17bang.bak' 