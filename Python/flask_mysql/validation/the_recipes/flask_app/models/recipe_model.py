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
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']
        self.user_id = data['user_id']

    @classmethod
    def create(cls, data):
        query = '''
        INSERT INTO recipes(name, description, instructions, user_id)
        VALUES (%(name)s, %(description)s, %(instructions)s, %(user_id)s);
        '''
        return connectToMySQL(DATABASE).query_db(query, data)

    @classmethod
    def get_all(cls,data):
        query = '''
        SELECT * FROM recipes
        JOIN users ON recipes.user_id = recipes.id;
        '''
        results = connectToMySQL(DATABASE).query_db(query,data)
        all_recipes = []
        if results:
            for row in results:
                this_recipe = cls(results[0])
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