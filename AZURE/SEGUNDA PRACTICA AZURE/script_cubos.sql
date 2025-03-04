CREATE TABLE COMPRACUBOS(
	id_pedido int PRIMARY KEY NOT NULL,
	id_cubo int NOT NULL,
	id_usuario int NOT NULL,
	fechapedido datetime NOT NULL)
GO
CREATE TABLE CUBOS(
	id_cubo int PRIMARY KEY NOT NULL,
	nombre nvarchar(50) NOT NULL,
	marca nvarchar(50) NOT NULL,
	imagen nvarchar(500) NOT NULL,
	precio int NOT NULL)
GO
CREATE TABLE USUARIOSCUBO(
	ID_USUARIO int PRIMARY KEY NOT NULL,
	NOMBRE nvarchar(50) NULL,
	EMAIL nvarchar(100) NULL,
	PASS nvarchar(50) NULL,
	imagen nvarchar(500) NOT NULL,)
GO
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (1, 1, 1, CAST(N'2022-11-11T00:00:00.000' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (2, 2, 1, CAST(N'2022-11-12T00:00:00.000' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (3, 3, 1, CAST(N'2022-11-19T12:57:36.487' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (4, 4, 4, CAST(N'2022-11-21T09:42:53.840' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (5, 4, 4, CAST(N'2022-11-21T09:44:22.160' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (6, 4, 4, CAST(N'2022-11-21T09:44:31.237' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (7, 4, 1, CAST(N'2022-11-21T09:44:37.517' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (8, 4, 3, CAST(N'2022-11-21T09:45:13.720' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (9, 5, 2, CAST(N'2022-11-21T09:45:18.823' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (10, 5, 6, CAST(N'2022-11-21T09:46:08.400' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (11, 3, 5, CAST(N'2022-11-21T09:47:34.647' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (12, 3, 4, CAST(N'2022-11-21T09:47:42.850' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (13, 4, 3, CAST(N'2022-11-21T09:47:49.343' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (14, 4, 2, CAST(N'2022-11-21T09:48:10.043' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (15, 4, 4, CAST(N'2022-11-21T09:48:29.757' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (16, 4, 3, CAST(N'2022-11-21T09:48:54.383' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (17, 5, 2, CAST(N'2022-11-21T09:48:58.467' AS DateTime))
INSERT COMPRACUBOS (id_pedido, id_cubo, id_usuario, fechapedido) VALUES (18, 3, 2, CAST(N'2022-11-21T09:49:02.900' AS DateTime))

GO
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (1, N'Kylin Pillow 3x3', N'Yuxin','yuxin-kylin-pillow-3x3.jpg', 6)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (2, N'Megaminx', N'Megaminx', 'shengshou-legend-3x3-s.jpg', 3)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (3, N'Shield', 'DianSheng', N'diansheng-blade.jpg', 10)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (4, N'Sandwich', 'QiYi MoFangGe', N'17c496ece5b2e99c316777d06ef23eb63b433efa_original.jpeg', 3)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (5, N'Mirror 2x2x2','QiYi MoFangGe', N'554080103-0.jpg', 4)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (6, N'Meilong Pyraminx','MoYu', N'4545050103-0.jpg', 4)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (7, N'Fisher cube', 'QiYi MoFangGe', N'b8912421b62b2be51f17fd3a9bf39a499f580d5e_original.jpeg', 5)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (8, N'Lingpo', 'MoYu', N'61ZhSt6ZshL._SL1001_.jpg', 3)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (9, N'Skewb','ShengShou Cube', N'qiyi-qiheng-skewb.jpg', 5)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (10, N'Yileng Fisher', 'Fisher', 'qiyi-yileng-fisher-negro.jpg', 6)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (11, N'Megaminx 13x13x13', 'ShengShou Cube','26dfa7e1eca203c545b2d58711ca29ad.jpg', 59)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (12, N'Elephant 2x2x2',N'QiYi MoFangGe','yongjun-special-2x2x2-cube-elephant-blue-35135.jpg', 6)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (14, N'Mastermorphix 3x3x3', N'Mastermorphix', 'qiyi-mastermorphix.jpg', 5)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (15, N'Weipo WRS','MoYu','moyu-weipo-wrs-m-2x2.jpg', 4)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (16, N'DaYan TengYun','Dayan', N'dayan-tengyun-2x2-plus-m.jpg', 4)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (17, N'Qiyi Wuxia', 'QiYi MoFangGe', N'qiyi-wuxia-2x2-magnetico.jpg', 18)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (18, N'Shengshou 6x6', 'ShengShou Cube', N'shengshou-6x6.jpg', 20)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (19, N'Teraminx', 'ShengShou Cube', N'shengshou-teraminx.jpg', 70)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (20, N'Blue Kylin', 'Yuxin', N'yuxin-4x4-blue-kylin.jpg', 13)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (21, N'HuangLong', 'Yuxin', 'yuxin-9x9-huanglong.jpg', 65)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (22, N'Yuexiao 3x3 Pro', 'Guo Guan', N'guoguan-yuexiao-3x3-pro.jpg', 18)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (23, N'Xinghen', 'Guo Guan', N'guoguan-xinghen-2x2.jpg', 11)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (24, N'Xinghen M', 'Guo Guan', N'guoguan-xinghen-m-2x2.jpg', 17)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (25, N'Mirror', 'Hello Cube', N'hello-cube-mirro-2x2.jpg', 9)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (26, N'Gear Cube', 'Hello Cube', N'helocube-gear-cube-3x3.jpg', 6)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (27, N'Cube Flat', 'Hello Cube', N'hello-cube-flat-2x2-.jpg', 8)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (28, N'Bandaged Kit', 'CubeTwist', N'cubetwist-bandaged-kit-3x3.jpg', 16)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (29, N'Oskar Gear', 'CubeTwist', N'cubetwist-oskar-gear-cube-5x5.jpg', 23)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (30, N'Feichang', 'Cyclone Boys', N'cyclone-boys-2x2-feichang.jpg', 5)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (31, N'Speed Cloud', 'Cyclone Boys', 'cyclone-boys-3x3-speed-cloud.jpg', 6)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (32, N'Pyraminx','Cyclone Boys', 'cyclone-boys-pyraminx.jpg', 10)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (33, N'Feichi', 'Cyclone Boys', N'cyclone-boys-3x3-feichi.jpg', 9)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (34, N'Feilong', 'Cyclone Boys', N'cyclone-boys-feilong-6x6.jpg', 19)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (35, N'Feijue magnetico', 'Cyclone Boys', N'cyclone-boys-feiju-3x3-magnetico.jpg', 11)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (36, N'Skewb magnetico', 'Cyclone Boys', N'cyclone-boys-skewb-magnetico.jpg', 9)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (37, N'Megaminx', 'Cyclone Boys','cyclone-boys-megaminx.jpg', 9)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (38, N'Brick cube', 'DianSheng', N'diansheng-brick-cube.jpg', 10)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (39, N'Crazy', 'DianSheng', N'diansheng-3x3x2-crazy.jpg', 9)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (40, N'Cilindrico', 'DianSheng', N'diansheng-3x3-cilindrico.jpg', 7)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (41, N'Blade', 'DianSheng', N'diansheng-blade.jpg', 10)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (42, N'Ufo', 'DianSheng', N'diansheng-ufo.jpg', 8)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (43, N'Corner', 'DianSheng', N'diansheng-6-corner.jpg', 8)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (44, N'Layer Square', 'DianSheng', N'diansheng-2-layer-square1.jpg', 6)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (45, N'Queso', 'DianSheng', N'diansheng-2x2-queso.jpg', 7)
INSERT CUBOS (id_cubo, nombre,  marca, imagen, precio) VALUES (46, N'Cube of Mouse', 'DianSheng', 'diansheng-cube-of-mouse.jpg', 6)
GO
INSERT USUARIOSCUBO (ID_USUARIO, NOMBRE, EMAIL, PASS, IMAGEN) VALUES (1, N'LEONARD', N'leonard@gmail.com', N'12345', 'leonard.jpg')
INSERT USUARIOSCUBO (ID_USUARIO, NOMBRE, EMAIL, PASS, IMAGEN) VALUES (2, N'SHELDON', N'sheldon@gmail.com', N'12345', 'sheldon.webp')
INSERT USUARIOSCUBO (ID_USUARIO, NOMBRE, EMAIL, PASS, IMAGEN) VALUES (3, N'PENNY', N'penny@gmail.com', N'12345', 'penny.jpg')
INSERT USUARIOSCUBO (ID_USUARIO, NOMBRE, EMAIL, PASS, IMAGEN) VALUES (4, N'HOWARD', N'howard@gmail.com', N'12345', 'howard.jpg')
INSERT USUARIOSCUBO (ID_USUARIO, NOMBRE, EMAIL, PASS, IMAGEN) VALUES (5, N'RAJESH', N'rajesh@gmail.com', N'12345', 'rajesh.jpg')
INSERT USUARIOSCUBO (ID_USUARIO, NOMBRE, EMAIL, PASS, IMAGEN) VALUES (6, N'STUART', N'stuart@gmail.com', N'12345', 'stuart.jpg')
