﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models {
    class Configuration :DbMigrationsConfiguration<BooksDbContext>{

        public Configuration() {
            AutomaticMigrationsEnabled = true; //自動マイグレーションの有効化
            AutomaticMigrationDataLossAllowed = true;　//データロスを伴う変更を許可
            ContextKey = "SampleEntityFramework.Models.BooksDbContext";
        }
    }
}
