from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import DATABASE
from flask import flash
import re
EMAIL_REGEX = re.compile(r"^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$")

class User: 
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.password = data['password']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @classmethod
    def create(cls, data):
        query = '''
        INSERT INTO users(first_name, last_name, email, password)
        VALUES (%(first_name)s, %(last_name)s, %(email)s, %(password)s);
        '''
        return connectToMySQL(DATABASE).query_db(query, data)

    @classmethod
    def get_by_email(cls,data):
        query = '''
        SELECT * FROM users WHERE email = %(email)s;
        '''
        results = connectToMySQL(DATABASE).query_db(query,data)
        if len(results) < 1:
            return False
        return cls(results[0])

    @classmethod
    def get_by_id(cls,data):
        query = '''
        SELECT * FROM users WHERE id = %(id)s;
        '''
        results = connectToMySQL(DATABASE).query_db(query,data)
        if len(results) < 1:
            return False
        return cls(results[0])


    @staticmethod
    def validator(data):
        is_valid = True

        # NAME
        if len(data['first_name']) < 1:
            flash('First Name Required', 'reg')
            is_valid = False
        if len(data['last_name']) < 1:
            flash('Last Name Required', 'reg')
            is_valid = False

        # EMAIL
        if len(data['email']) < 1:
            flash('Email Required', 'reg')
            is_valid = False
        elif not EMAIL_REGEX.match(data['email']):
            flash("Invalid email", 'reg')
            is_valid = False
        else:
            user_data = {
                'email':data['email']
            }
            potential_user = User.get_by_email(user_data)
            if potential_user:
                flash("Email already taken", 'reg')
                is_valid = False

        # PASSWORD
        if len(data['password']) < 1:
            flash('Password Required', 'reg')
            is_valid = False
        elif not data['password'] == data['confirm_password']:
            flash("Passwords don't match", 'reg')
            is_valid = False
        return(is_valid)