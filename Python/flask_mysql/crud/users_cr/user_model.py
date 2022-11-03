from mysqlconnection import connectToMySQL

DATABASE = 'users_schema'

class User: 
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @classmethod 
    def get_all(cls):
        query = 'SELECT * FROM users;'
        results = connectToMySQL(DATABASE).query_db(query)
        print(results)
        all_users = []
        if results: 
            for row in results:
                this_user = cls(row)
                all_users.append(this_user)
        return all_users

    @classmethod
    def create(cls, data):
        query = '''
        INSERT INTO users(first_name, last_name, email)
        VALUES (%(first_name)s, %(last_name)s, %(email)s)
        '''
        return connectToMySQL(DATABASE).query_db(query, data)