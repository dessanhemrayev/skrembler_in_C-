a=[1,1,0,1,0,1,1,1]
b=[0,0,0,0,0,0,0,0]
c=[0,0,0,0,0,0,0,0]
print(a)
print("Skrembler")
for i in range(len(a)):
    if i-3<0 and i-5<0:
        b[i]=a[i]
        print(b)
    elif i-3>=0 and i-5<0:
        b[i]=a[i] ^b[i-3]
        print(b)
    elif i-3>=0 and i-5>=0: 
        b[i]=a[i] ^b[i-3]^b[i-5]
        print(b)

print("signal")

print(b)

print("deskrembler")

for i in range(len(b)):
    if i-3<0 and i-5<0:
        c[i]=b[i]
        print(c)
    elif i-3>=0 and i-5<0:
        c[i]=b[i] ^b[i-3]
        print(c)
    elif i-3>=0 and i-5>=0: 
        c[i]=b[i] ^b[i-3]^b[i-5]
        print(c)
