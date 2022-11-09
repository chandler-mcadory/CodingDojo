from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import DATABASE
from flask import flash
from flask_app.models import user_model


class Recipe:
    def __init__ (self,data):
        self.id = data['id']
        self.name = data['name']
        self.description = data['description']
        self.instructions = data['instructions']
        self.date = data['date']
        self.under_30 = data['under_30']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.user_id = data['user_id']

    @classmethod
    def create(cls, data):
        query = '''
        INSERT INTO recipes(name, description, instructions, user_id, under_30)
        VALUES (%(name)s, %(description)s, %(instructions)s, %(user_id)s, %(under_30)s);
        '''
        return connectToMySQL(DATABASE).query_db(query, data)

    @classmethod
    def get_all(cls):
        query = '''
        SELECT * FROM recipes
        JOIN users ON recipes.user_id = users.id;
        '''
        results = connectToMySQL(DATABASE).query_db(query)
        all_recipes = []
        if results:
            for row in results:
                this_recipe = cls(row)
                user_data = {
                    **row,
                    'id': row['users.id'],
                    'created_at': row['users.created_at'],
                    'updated_at': row['users.updated_at']
                }
                this_user = user_model.User(user_data)
                this_recipe.planner = this_user
                all_recipes.append(this_recipe)
        return all_recipes

    @classmethod
    def get_by_id(cls,data):
        query = '''
        SELECT * FROM recipes
        JOIN users ON recipes.user_id = users.id
        WHERE recipes.id = %(id)s;
        '''
        results = connectToMySQL(DATABASE).query_db(query,data)
        print(results)
        if results:
            this_recipe = cls(results[0])
            row = results[0]
            user_data = {
                **row,
                'id': row['users.id'],
                'created_at': row['users.created_at'],
                'updated_at': row['users.updated_at']
                }
            this_user = user_model.User(user_data)
            this_recipe.planner = this_user
            return this_recipe
        return False

    @classmethod
    def update(cl,data):
        query = '''
        UPDATE recipes SET name = %(name)s, description = %(description)s, 
        instructions = %(instructions)s, date = %(date)s, under_30 = %(under_30)s
        WHERE id = %(id)s;
        '''
        return connectToMySQL(DATABASE).query_db(query,data)

    @classmethod
    def delete(cl,data):
        query = '''
        DELETE FROM recipes
        WHERE id = %(id)s;
        '''
        return connectToMySQL(DATABASE).query_db(query,data)

    @staticmethod
    def validator(form_data):
        is_valid = True
        if len(form_data['name']) < 1:
            flash('name required')
            is_valid = False
        if len(form_data['description']) < 1:
            flash('description required')
            is_valid = False
        if len(form_data['instructions']) < 1:
            flash('instructions required')
            is_valid = False
        if len(form_data['date']) < 1:
            flash('date required')
            is_valid = False
        if "under_30" not in form_data:
            flash("under 30 minute selection required")
            is_valid = False
        return is_valid