**Лабораторная работа 2 по предмету "Компьютерная графика"*

**Описание**: десктопное приложение позволяет пользователю получить структурированную информацию из графического файла/файлов. Программа написана при помощи языка C# и средств WPF. Для извлечения метаданных о изображении использовались возможности класса System.Drawing.Image и внешней библиотеки [Metadata Extractor](https://www.nuget.org/packages/MetadataExtractor/).

**Установка**: для запуска программы необходимо скачать содержимое репозитория, пройти по пути _lab2 - bin - Release_  и дважды кликнуть на "lab2.exe".

**Использование**: программа предусматривает обработку одиночных файлов или всего содержимого папки. 

В таблице информация представлена пятью параметрами: имя файла, размер изображения (pixels), разрешение (dot/inch), глубина цвета (bit per pixel), тип сжатия (в случае невозможности его определения отображается N/A).

Пример работы программы <br /> ![main](/screenshots/main.png)

Для корректной работы необходимо использовать изображения следующих шести форматов: jpg, gif, tif, bmp, png, pcx. В случае загрузки файла неподдерживаемого формата будет подсвечено предупреждение.   

Пример предупреждения <br /> ![warning](/screenshots/warning.png)
