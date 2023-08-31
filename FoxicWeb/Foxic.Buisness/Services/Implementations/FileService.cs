﻿using Foxic.Business.Exeptions;
using Foxic.Business.Services.Interfaces;
using Foxic.Business.Utilities;
using Microsoft.AspNetCore.Http;

namespace Foxic.Business.Services.Implementations;

public class FileService: IFileService
{
	public void RemoveFile(string root, string filePath)
	{
		string fileroot = Path.Combine(root, filePath);
		if (File.Exists(fileroot))
		{
			File.Delete(fileroot);
		}
	}

	public async Task<string> UploadFile(IFormFile file, string root, int kb, params string[] folders)
	{
		if (!file.CheckFileSize(kb))
		{
			throw new FileSizeException("Size is incorrect!");
		}
		if (!file.CheckFileType("image"))
		{
			{
				throw new FileTypeException("Type is incorrect!");
			}
		}
		string folderRoot = string.Empty;
		foreach (var folder in folders)
		{
			folderRoot = Path.Combine(folderRoot, folder);
		}
		string filename = await file.UploadFile(root, folderRoot);
		return filename;
	}
}
