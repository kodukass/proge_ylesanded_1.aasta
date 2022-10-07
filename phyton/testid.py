def fun(loe):
    if loe==0:
        print("Lõpp")
    else:
        print(loe)
        fun(loe-1)
fun(3)