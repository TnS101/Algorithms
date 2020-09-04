def sum(left,right):
    print(left + right)

def get_duplicate(arr):
    m = set()
    for num in arr:
        if m.__contains__(num):
            print(num)
            break
        else:
            m.add(num)

def arr_concat(left, right):
    print(left + right)

def remove_duplicates(arr):
    print(list(dict.fromkeys(arr)))

def reverse_string(str):
    print(str [::-1])

def slice_string(str, start, end):
    print(str[start:end])

def insert_at_position(str, sub, pos):
    print(str[0:pos] + sub + str[pos:len(str)])

def order_arr_by_criteria(arr, rev):
    print(sorted(arr, key = crit_money, reverse = rev))

def crit_money(obj):
    return obj.get('money')

def cv_builder():
    name = input('Your Name: ')
    years = input('Years of Experience: ')
    lang = input('Programming Language: ')

    txt = 'My name is {} and I have {} years of experience with {}.'

    print(txt.format(name, years, lang))

print(sum(1,2))

get_duplicate([1,2,3,4,5,6,7,7])

arr_concat(['1','2','3'],['4','5','6'])

remove_duplicates([1,2,2,3,4,4,5,5,6,6,6,6,7,8,8])

reverse_string('Reverse Me')

slice_string('123456', 0, 2)

insert_at_position('12367', '45', 3)

print(sorted([3,4,6,1,2,5,9,12,10]))

cv_builder()