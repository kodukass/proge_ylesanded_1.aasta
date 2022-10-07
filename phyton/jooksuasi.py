def lõimede_pikkus(lõpppikkus,lõimedearv):
    kogupikkus = lõimedearv * (lõpppikkus * 1,2 + 0,5)
    print(kogupikkus)
    
lõimede_pikkus(7,120)

# # # failinimi=input("Failinimi: ")
# # # pikad=int(input("Pikad lõimed: "))
# # # lühikesed=int(input("Lühikesed lõimed: "))
# # # kokku=pikad+lühikesed
# # # 
# # # vaibapikkus = []
# # # fail = open(failinimi)
# # # for rida in fail:
# # #     vaibapikkus+=[float(rida)]
# # #     
# # # for lõpp in vaibapikkus:
# # #     lõpp = lõimede_pikkus(vaibapikkus,kokku)






# def parandatud_tulemus(viganeTulemus,parandus):
#     return viganeTulemus+parandus/100
# 
# failinimi=input("Failinimi: ")
# mparandus=int(input("Mõõteparandus: "))
# normatiiv=float(input("Normatiiv: "))
# print("Tegelikud tulemused")
# mõõted = []
# fail = open(failinimi)
# for rida in fail:
#     mõõted+=[float(rida)]
# 
# tegelik=[]
# for tulemus in mõõted:
#     tegeliktulemus = parandatud_tulemus(tulemus, mparandus)
#     print(round(tegeliktulemus, 2))
#     tegelik += [tegeliktulemus]
#     
# head=0
# halvad=0
# for tulemus in tegelik:
#     if tulemus>= normatiiv:
#         head=head+1
#         halvad=halvad+tulemus
# print("normatiivi ületajad " +str(head))
# if head>0:
#     print("keskmine on "+str(round(halvad/head,2)))