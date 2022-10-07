# # # # from datetime import *
# # # # failinimi = (input("Sisestage failinimi: "))
# # # # 
# # # # if failinimi == "nimekiri.txt":
# # # #     fail = open("nimekiri.txt", encoding="UTF-8")
# # # # 
# # # #     nimed = []
# # # # 
# # # #     for rida in fail:
# # # # 
# # # #         nimed.append(rida.strip("\n"))
# # # #         
# # # #     fail.close()
# # # # 
# # # # #print(nimed)
# # # # 
# # # # #print(datetime.now().day)
# # # # #for i in range(1, len(nimed), 2):
# # # # print("Vastama tuleb: " + nimed[datetime.now().day])

from datetime import *
failiNimi=input("Sisesta faili nimi: ")
nimekiri=[]
with open(failiNimi,encoding="UTF-8") as file:
    for rida in file:
        nimekiri.append(rida.rstrip("\n"))
print("Vastama tuleb: "+nimekiri[datetime.now().day-1])



# fail1 = open("sisseränne.txt", encoding="UTF-8")
# 
# sisseränne = []
# 
# for rida in fail1:
# 
#     sisseränne.append(int(rida))
# 
# fail2 = open("väljaränne.txt", encoding="UTF-8")
# 
# väljaränne = []
# saldo=[]
# 
# for rida in fail2:
# 
#     väljaränne.append(int(rida))
#     
# fail1.close()
# fail2.close()
# 
# for i in range(0, len(sisseränne), 1):
#     summa = sisseränne[i] - väljaränne[i] 
#     saldo.append(summa)
# print(saldo)
# 
# suurim_saldo =  max(saldo)
# 
# for i in range(0, len(saldo), 1):
#     i=
# 
# if suurim_saldo > 0:
#     print("Suurim positiivne rändesaldo oli "+ str(i) +". aastal.")
# else:
#     print("Positiivse rändesaldoga aastaid ei ole.")
#     
#     
# fail=open("sisseränne.txt", encoding="UTF-8")
# sisse=[]
# for rida in fail:
#     sisse +=[int(rida)]
#     #sisse.append(int(rida))
# fail.close()
# fail=open("väljaränne.txt", encoding="UTF-8")
# välja=[]
# for rida in fail:
#     välja +=[int(rida)]
#     #sisse.append(int(rida))
# fail.close()
# saldo=[]
# for i in range(len(sisse)):
#     saldo.append(sisse[i]-välja[i])
# print(saldo)
# suurimSaldo=max(saldo)
# print(suurimSaldo)
# if suurimSaldo<0:
#     print("Positiivse rändesaldoga aastaid ei ole.")
# else:
#     print("Suurim positiivne rändesaldo oli"+str(saldo.index(suurimSaldo)+1)+". aastal.")
# # failinimi = str(input("Palun sisestage faili nimi: "))
# 
# if failinimi == "jukebox.txt":
#     laulud = "jukebox.txt"
# elif failinimi == "80ndad.txt":
#     laulud = "80ndad.txt"
# elif failinimi == "eesti muusika.txt":
#     laulud = "eesti muusika.txt"
# elif failinimi == "edm.txt":
#     laulud = "edm.txt"
#     
# readfailist = open(failinimi, encoding = "UTF-8")
# read = []                                #ilma reavahetusteta ridade list
# for rida in readfailist:                 #reakaupa listist readfailist
# #         read = read + [rida.strip("\n")] #ilma reavahetuseta rida lisatakse listi
#         read.append(rida.strip("\n"))
# readfailist.close() # faili ei lähe enam vaja
# # print(read[9])
# #for i in range (1,3):
# i = 0
# print("Muusikapalade valik: ")
# #for i in range (1,10):
# while i < len(read):
#     #print(read[i])
#     print(str(i+1)+". "+read[i])
#     i += 1
#     #read[0] = read[0] + i
# #     print(str(i+1)+". "+read[9])
#     
# valik=int(input("Valige laulu järjekorranumber: "))
# print("Mängitav muusikapala on "+read[valik-1])