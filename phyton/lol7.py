# # # def kuu_nimi(kuu):
# # #     a=["jaanuar","veebruar","märts"]
# # #     for kuu in range[a]:
# # #         print(a[kuu])
# # #         
# # # def kuupäev_sõnena(kuupäev):
# # #     print(str((kuupäev.split(".",1)+kuu_nimi(küskuu)+(kuupäev.split(".",3)))))
# # # #         
# # # küskuu=input("kuu nr plz ")
# # # # kuupäev_sõnena(küskuu)
# # # print(kuupäev_sõnena(küskuu))


# # # def pronksikarva_summa(järjend):
# # #     i=0
# # #     kokku=0
# # #     while i < len(a):
# # #         if järjend[i] > 5:
# # #             järjend[i] = 0
# # #             kokku += i
# # #             return
# # #         i += 1
# # #         
# # # failinimi=input("Sisesta failinimi: ")
# # # fail = open(failinimi, encoding="UTF-8")
# # # a = []
# # # for rida in fail:
# # #     a.append(int(rida))   
# # # fail.close()
# # # pronksikarva_summa(a)
# # # print("Hoiupõrsasse läheb "+str(kokku)+" senti.")

# def tervitus(n):
#     print('Võõrustaja: "Tere!"')
#     print("Täna "+ str(i+1)+".kord tervitada, mõtiskleb võõrustaja.")
#     print('Külaline: "Tere, suur tänu kutse eest!"')
# 
# e=int(input("Sisestage külaliste arv: "))
# for i in range(e):
#     tervitus(e)
    
    
def eelarve(inimeste_arv):
    return round(int(inimeste_arv)*10+55)

maxinimesed=str(input("Mitu inimest on kutsutud? "))
mininimesed=str(input("Mitu inimest tuleb? "))
print("Maksimaalne eelarve: "+str((eelarve(maxinimesed))))
print("Minimaalne eelarve: "+str((eelarve(mininimesed))))



# def mahlapakkide_arv(n):
#     return round((n * 0.4)/3)
#     
# õunad=float(input("Sisestage õunte kogus kilogrammides: "))
# print(mahlapakkide_arv(õunad))


# # # def banner(i):
# # #     #i=input("sisesta midagi")
# # #     i=sõna
# # #     print(i.upper())
# # # 
# # # korrad=input("Mitu korda soovite reklaamlauset korrata? ")
# # # sõna=input("Sisestage reklaamlause: ")
# # # for sõna in range("korrad"):
# # #     banner(sõna)