# inventory-managment-system-university-project
## İstifadə olunan texnologiyalar:
.NET Framework v4.7.2
Entity Framework 6(Database First)
MS Sql
Inventar idarəetmə sistemi böyük və kompleks sistemdir. Proyekt bir neçə moduldan ibraətdir. Əsasən 2 idarəetmə sistemi var. Bir normal şirkətlər özləri qeydiyyatdan keçərək istədikləri məhsulları sifariş edə bilər bir də admin tərəfindən məhsullar sifariş edilib təsdiqlənə bilər. Database olaraq MS Sql server istifadə olunub və baza ilə əlaqəni təmin etmək üçün Entity Framework.
## Giriş Pəncərəsi:
![image](https://user-images.githubusercontent.com/47367245/83322001-44ecfd00-a265-11ea-984a-2993943680eb.png)
Proqramın açılış pəncərəsində bizi giriş qarşılayır. Daxil edilən məlumatlara əsasən uyğun formlara yönədir. 2 əsas form var 1 user üçün nəzədə tutlan 2 admin üçün nəzərdə tutulan. Hər bir qeydiyyatdan keçən istifadəçinin rolu userdir.
## Qeydiyyat:
![image](https://user-images.githubusercontent.com/47367245/83322025-71a11480-a265-11ea-9a03-e9befd32ce2d.png)\
Şəkildə göstərilən bütün məlumatları dolduraraq bazada uyğun user yaradılır.
## Admin Panel:
![image](https://user-images.githubusercontent.com/47367245/83322060-bb89fa80-a265-11ea-8e66-5d54a8c12025.png)\
Admin paneldə sol üstə user məlumatları var ortada ən çox satılan və ən son satılan 5 məhsul var. Sağ altda APİ ilə alınan və günlük dəyişən valyuta cədvəli var. Aşağıda İstifadəçi, Məhsul və invoice sayını görmək olar.
## Məhsul:
![image](https://user-images.githubusercontent.com/47367245/83322072-d5c3d880-a265-11ea-83d7-9bd0b84c9f5c.png)\
Bu pəncərədə məhsulları idarə etmək mümkündür. Yeni məhsul əlavə edə, var olanları dəyişə və ya silə bilərsiniz. Yuxarı sağda real-time olaraq axtarış həyata keçirmək mümkündür.
## İstifadəçilər:
![image](https://user-images.githubusercontent.com/47367245/83322091-f3913d80-a265-11ea-9544-fe861d3ed08b.png)
![image](https://user-images.githubusercontent.com/47367245/83322096-fc820f00-a265-11ea-9895-24ecdba41171.png)\
Bu səhifədə admin userlərin bəzi məlumatlarını dəyişə və görə bilər. Sağdakı pəncərədə isə hər bir user öz adını, şifrəsini, mailini və profil şəklini dəyişə bilir.
## Sifariş:
![image](https://user-images.githubusercontent.com/47367245/83322117-1facbe80-a266-11ea-90d5-3412b8730e93.png)\
Burada admin istənilən şirkət üçün məhsulları seçin sifariş yarda bilər, amma normaı user ancaq qeydiyyatda olduğu şirkət üçün sifariş yarada bilər. Order yaradarkən digar valuyatadakı pullar günlük valyutaya əsasən AZNə çevrilir.\
![image](https://user-images.githubusercontent.com/47367245/83322125-3c48f680-a266-11ea-8948-d3ca59b01eab.png)\
Bu pəncərədə orderləri idarə etmək üçündür. Qabağcadan invoice yaradılmış orderlərin arxa fonu yaşıl olur və onların yenidən invoicenu yarada və silə bilmərsiniz.(Xəta verir)
## İnvoice:
![image](https://user-images.githubusercontent.com/47367245/83322147-5f73a600-a266-11ea-9246-b153d89c4fc6.png)\
Hər hansısa bir sifarişdən invoice yaradılan zaman belə bir pəncərə açılır. Sağdan istənilən məhsulu seçə bilirsiniz. İnvoice yaradılan zaman məhsullar cədvəlində satılan məhsulların ümumi sayından satılan say qədər çıxılır.\
![image](https://user-images.githubusercontent.com/47367245/83322159-71eddf80-a266-11ea-8eb3-ecf6c2178afa.png)\
Buradan isə yaradılmış invoicelərə baxmaq və invoice məhsullarına baxmaq olar. İnvoice cədvəlini Excel file olaraq giriş edən userin mailinə göndərə və ya print etmək mümkündür.
## Kateqoriyalar:
![image](https://user-images.githubusercontent.com/47367245/83322174-8631dc80-a266-11ea-85be-f977db6cc5e6.png)\
Bu pəncərədə kateqoriyaları əlavə etmək və düzəliş etmək mümkündür.
## User səhifəsi:
![image](https://user-images.githubusercontent.com/47367245/83322185-98137f80-a266-11ea-85f4-44c86fb30c80.png)\
Bu səhifə ancaq adi userlər üçündür. Burada istifadəçi öz order sayını görə və yeni order yarada bilər. 

