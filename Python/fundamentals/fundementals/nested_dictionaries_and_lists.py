# x = [ [5,2,3], [10,8,9] ] 
# students = [
#      {'first_name':  'Michael', 'last_name' : 'Jordan'},
#      {'first_name' : 'John', 'last_name' : 'Rosales'}
# ]
# sports_directory = {
#     'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
#     'soccer' : ['Messi', 'Ronaldo', 'Rooney']
# }
# z = [ {'x': 10, 'y': 20} ]

# # ========= PART 1 ==========

# x[1][0] = 15 #1

# students[0]["last_name"] = 'Bryant' #2

# sports_directory['soccer'][0] = 'Andres'

# z[0]['y'] = 30


# ========= PART 2 ==========

# def iterateDictionary(some_list):
#     for i in (some_list):
#         print(f'first_name - {i["first_name"]}, last_name - {i["last_name"]}')

# students = [
#         {'first_name':  'Michael', 'last_name' : 'Jordan'},
#         {'first_name' : 'John', 'last_name' : 'Rosales'},
#         {'first_name' : 'Mark', 'last_name' : 'Guillen'},
#         {'first_name' : 'KB', 'last_name' : 'Tonel'}
#     ]
# iterateDictionary(students) 


# ========= PART 3 ==========

# def iterateDictionary2(key_name, some_list):
#     for i in range(len(some_list)):
#         print(students[i][key_name])

#         iterateDictionary2('first_name', students)
#         iterateDictionary2('last_name', students)


# ========= PART 4 ==========

# dojo = {
#     'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
#     'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
# }

# def printInfo(some_dict):
#     for key in some_dict:
#         print(len(some_dict[key]), key)
#         for val in some_dict[key]:
#             print(val)

# printInfo(dojo)