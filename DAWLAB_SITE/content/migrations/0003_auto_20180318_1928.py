# -*- coding: utf-8 -*-
# Generated by Django 1.11.10 on 2018-03-18 19:28
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('content', '0002_auto_20180318_1924'),
    ]

    operations = [
        migrations.AlterModelOptions(
            name='employee',
            options={},
        ),
        migrations.AlterField(
            model_name='employee',
            name='last_name',
            field=models.TextField(default='', unique=True),
        ),
        migrations.AlterUniqueTogether(
            name='employee',
            unique_together=set([]),
        ),
    ]
