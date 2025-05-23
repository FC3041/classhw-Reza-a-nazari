a = [1,4,5,2,3,10,6,7,8,9]
b=[]
j=0
for i in range(len(a)):
    if a[i]<a[j]:
        b.append(a[i])
        j+=1

print(b)