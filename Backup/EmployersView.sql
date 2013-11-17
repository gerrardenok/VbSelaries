SELECT        Работник.Имя, Работник.Фамилия, Работник.Отчество, Работник.Дата_приёма AS 'Дата приёма', Работник.Телефон, 
                         Работник.Номер_пасспорта AS 'Номер пасспорта', Работник.Стаж AS 'Стаж(полных лет)', Специальность.Название AS 'Специальность', 
                         Отдел.Название AS Отдел
FROM            Работник INNER JOIN
                         Специальность ON Работник.Код_специальности = Специальность.Код_специальности INNER JOIN
                         Отдел ON Работник.Код_отдела = Отдел.Код_отдела
WHERE        (Работник.Дата_увольнения IS NULL)

--- Доп колонка вид ставки

IIf([Ставка]=0, '0,5 ставки',IIf([Ставка]=1, 'Полная ставка',IIf([Ставка]=2, '0,25 ставки', 'Неизвестные вид ставки')))