def findZigZagSequence(a, n):
    # a.sort()
    # mid = int((n + 1)/2)
    # # a[mid], a[n-1] = a[n-1], a[mid]
    # a[mid - 1], a[n-1] = a[n-1], a[mid - 1]

    # # st = mid + 1
    # st = mid
    # # ed = n - 1
    # ed = n - 2
    # while(st <= ed):
    #     a[st], a[ed] = a[ed], a[st]
    #     st = st + 1
    #     # ed = ed + 1
    #     ed = ed - 1

    # for i in range (n):
    #     if i == n-1:
    #         print(a[i])
    #     else:
    #         print(a[i], end = ' ')
    # return

    # Above code make 4 changes to make code work 
    # but here we will change only 3 line of code
    a.sort()
    # Removed useless +1
    # mid = int((n + 1)/2)
    mid = int(n/2)
    a[mid], a[n-1] = a[n-1], a[mid]

    st = mid + 1
    # -2 cause we already switched mid and end
    # ed = n - 1
    ed = n - 2
    while(st <= ed):
        a[st], a[ed] = a[ed], a[st]
        st = st + 1
        # -1 for decrementation
        # ed = ed + 1
        ed = ed - 1

    for i in range (n):
        if i == n-1:
            print(a[i])
        else:
            print(a[i], end = ' ')
    return

test_cases = int(input())
for cs in range (test_cases):
    n = int(input())
    a = list(map(int, input().split()))
    findZigZagSequence(a, n)