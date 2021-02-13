# Copyright (c) 2021, NVIDIA CORPORATION. All rights reserved.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

import os
import shutil
from model_analyzer.model_analyzer_exceptions \
    import TritonModelAnalyzerException


class ModelConfigManager:
    def __init__(self, model_output_path, model_repository):
        self._model_output_path = model_output_path
        self._model_repository = model_repository

        try:
            os.mkdir(self._model_output_path)
        except OSError:
            raise TritonModelAnalyzerException(
                f'Path "{self._model_output_path}" already exists.'
                ' Consider changing it using the '
                'tmp_model_repository_path config parameter.')

    def copy_model(self, model_config):
        model_name = model_config.get_field('name')
        shutil.copy(f'{self._model_repository}/{model_name}/',
                    f'{self._model_output_path}/{model_name}/')

    def write_model_configs(self, model_configs):
        for model_config in model_configs:
            self.write_model_config(model_config)

    def write_model_config(self, model_config):
        model_name = model_config.get_field('name')
        self.copy_model(model_config)
        model_config.write_config_to_file(f'{self._model_output_path}/'
                                          f'{model_name}/')
